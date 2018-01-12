using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace PracticalCourses.Infrastructure
{
    public static class UrlHelpers
    {
        private static string _imagesCategoriesPathRelative = "~/categories/";

        public static string ImagesCategoriesPathRelative
        {
            get
            {
                return _imagesCategoriesPathRelative;
            }
        }

        private static string _imagesCoursesPathRelative = "~/courses/";

        public static string ImagesCoursesPathRelative
        {
            get
            {
                return _imagesCoursesPathRelative;
            }
        }

        public static string PathToImagesCategories(this IUrlHelper helper, string nameImageCategory)
        {
            var imagesCategoriesFolder = ImagesCategoriesPathRelative;
            var path = Path.Combine(imagesCategoriesFolder, nameImageCategory);
            var pathAbsolute = helper.Content(path);

            return pathAbsolute;
        }

        public static string PathToImagesCourses(this IUrlHelper helper, string nameImageCourse)
        {
            var imagesCoursesFolder = ImagesCoursesPathRelative;
            var path = Path.Combine(imagesCoursesFolder, nameImageCourse);
            var pathAbsolute = helper.Content(path);

            return pathAbsolute;
        }
    }
}
