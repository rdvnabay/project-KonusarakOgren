namespace WebUI.Helper
{
    public static class XPathTagElement
    {
        public static string div = "//div[@class='secondary-grid-component']";
        public static string ul = "//ul[@class='post-listing-component__list']";
        public static string li = "//li[@class='post-listing-list-item__post']";

        //Title
        public static string h5 = "//h5[@class='post-listing-list-item__title']";

        //Links
        public static string a = "//a[@class='post-listing-list-item__link']";

        //Paragraph
        public static string paragraph = "//p[@class='paywall']";
    }
}
