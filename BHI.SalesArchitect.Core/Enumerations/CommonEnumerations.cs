namespace BHI.SalesArchitect.Core.Enumerations
{
    public class CommonEnumerations
    {
        public enum AjaxCallStatus
        {
            Accepted = 1,
            Error = 2
        }

        public enum RegistrationType
        {
            Email = 1,
            Facebook = 2,
            Google = 3,
            Guest = 4,
            Apple = 5,
            UUP = 6
        }

        public enum FieldType
        {
            RadioButton = 1,
            Text = 2
        }

        public enum NHNInvite
        {
            DoNotSend = 0,
            Send = 1

        }

        public enum RequestType
        {
            Login = 1,
            Register = 2,
            UUP = 3
        }

        public enum PartnerType
        {
            SalesArchitect = 1,
            NHNX = 2,
            BuilderBrandedApp = 3,
            Others = 4
        }

        public enum NHNXSource
        {
            BuilderSalesNavigator = 1,
            NHS = 2,
            BuilderWebsite = 3,
            Others = 4
        }
        public enum AssetTypes
        {
            GIF = 1,
            JPG = 2,
            TEXT = 3,
            XML = 4,
            HEXCOL = 5,
            GEN = 6
        }

        public enum PlatformType
        {
            iOS = 1,
            Android = 2,
            BSN = 3,
            AdminPanel = 4,
            ISP = 5,
            Plugin = 6
        }

        public enum ApiErrorType
        {
            Empty = 1,
            Null = 2,
            Exception = 3,
            Fail = 4
        }

        public enum IspPartnerType
        {
            SVG = 1,
            FreeGeoSpatial = 2,
            PaidGeoSpatial = 3,
            SVGGeoSpatial = 4
        }
        public enum FeedbackCategories
        {
            Compliment = 1,
            Suggestion = 2,
            Issue = 3,
            Other = 4
        }
        public enum CommunityAddSource
        {
            Others = 0,
            CommunityCode = 1,
            QRCode = 2,
            DeepLink = 3,
            HomeSync = 4
        }

        public enum PlacesNearBySearchRadius
        {
            Radius1 = 1604,
            Radius2 = 8020,
            Radius3 = 16040,
            Radius4 = 32080,
            Radius5 = 5000,
            Radius6 = 15000
        }

        public enum BookmarkContentTypes
        {
            Builder = 2,
            Community = 3,
            HomePlan = 4,
            HomeSpec = 5
        }
    }
}

