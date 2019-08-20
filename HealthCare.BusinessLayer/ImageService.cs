namespace HealthCare.BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Contracts.Configuration;
    using Microsoft.AspNetCore.Hosting;

    using Contracts.Interfaces;
    using Contracts.Models.UserAccount.Data;
    using DataLayer;
    using DataLayer.Entities.User;
    using Extensions;
    using Interfaces;
    using Microsoft.Extensions.Options;
    using Utilities.Enums;
    using Utilities.Exceptions.ImagesExceptions;

    public class ImageService : IImageService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly ISessionResolver _sessionResolver;
        private readonly IOptionsSnapshot<CommonSettings> _settings;

        public ImageService(HealthCareDbContext dbContext, IHostingEnvironment appEnvironment, ISessionResolver sessionResolver, IOptionsSnapshot<CommonSettings> settings)
        {
            _dbContext = dbContext;
            _appEnvironment = appEnvironment;
            _sessionResolver = sessionResolver;
            _settings = settings;
        }

        public void UploadImages(List<ImageData> images)
        {
            foreach (var img in images)
            {
                UploadImage(img);
            }
        }

        public void UploadImage(ImageData img)
        {
            if (img.Id == 0)
            {
                var image = new FileInfo(img.LocalPath);
                ValidateImage(image);

                var imageName = $"{_sessionResolver.SessionInfo.UserId}_{Guid.NewGuid()}";

                image.CopyTo(Path.Combine(Directory.GetCurrentDirectory(), _appEnvironment.WebRootPath, _settings.Value.ProfilePhotosPath, imageName));

                var newRecord = new Photo
                {
                    Url = Path.Combine(_appEnvironment.WebRootPath, _settings.Value.ProfilePhotosPath, imageName),
                    UserId = _sessionResolver.SessionInfo.UserId,
                    IsMain = img.IsMain
                };

                _dbContext.Add(newRecord);
            }
            else
            {
                var photo = _dbContext.Photos.SingleOrDefault(x => x.Id == img.Id);

                photo.IsMain = img.IsMain;
                photo.UpdateDate = DateTime.Now;
            }
        }

        private void ValidateImage(FileInfo image)
        {
            // should be imported in FluentValidation
            ValidationUtils.ValidateAndThrow<ImageNotFoundException>(() => !image.Exists);

            ValidationUtils.ValidateAndThrow<InvalidImageFormatException>(
                () => !Enum.IsDefined(typeof(ImageFormat), image.Extension.Replace(".", "")));

            ValidationUtils.ValidateAndThrow<InvalidImageSizeException>(() => image.Length > 2100000);
        }
    }
}