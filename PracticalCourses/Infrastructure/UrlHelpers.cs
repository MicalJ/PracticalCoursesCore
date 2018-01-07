using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace PracticalCourses.Infrastructure
{
    public static class UrlHelpers
    {
        public static string PathToImagesCategories(this IUrlHelper helper, string nameImageCategory)
        {
            var imagesCategoriesFolder = AppConfig.ImagesCategoriesPathRelative;
            var path = Path.Combine(imagesCategoriesFolder, nameImageCategory);
            var pathAbsolute = helper.Content(path);

            return pathAbsolute;
        }

        public static string PathToImagesCourses(this IUrlHelper helper, string nameImageCourse)
        {
            var imagesCoursesFolder = AppConfig.ImagesCoursesPathRelative;
            var path = Path.Combine(imagesCoursesFolder, nameImageCourse);
            var pathAbsolute = helper.Content(path);

            return pathAbsolute;
        }
    }
}
