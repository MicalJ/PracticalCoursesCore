namespace PracticalCourses.Infrastructure
{
    public class AppConfig
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
    }
}
