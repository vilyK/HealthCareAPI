namespace HealthCare.BusinessLayer.Extensions
{
    using System;
    using System.IO;

    using Utilities.Enums;
    using Utilities.Exceptions.ImagesExceptions;

    public static class ImageExtensions
    {
        public static string Upload(this FileInfo image, string destinationPath)
        {
            image.ValidateImage();

            var imageName = Guid.NewGuid().ToString();

            image.CopyTo(Path.Combine(destinationPath, imageName));

            return imageName;
        }

        private static void ValidateImage(this FileInfo image)
        {
            // should be in FluentValidation
            ValidationUtils.ValidateAndThrow<ImageNotFoundException>(() => !image.Exists);

            ValidationUtils.ValidateAndThrow<InvalidImageFormatException>(
                () => !Enum.IsDefined(typeof(ImageFormat), image.Extension.Replace(".", "")));

            ValidationUtils.ValidateAndThrow<InvalidImageSizeException>(() => image.Length > 2100000);
        }
    }
}
