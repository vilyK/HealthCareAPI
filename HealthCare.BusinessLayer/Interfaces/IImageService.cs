namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Collections.Generic;
    using Contracts.Models.UserAccount.Data;

    public interface IImageService
    {
        void UploadImage(ImageData img);

        void UploadImages(List<ImageData> images);
    }
}
