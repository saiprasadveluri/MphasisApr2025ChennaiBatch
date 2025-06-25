namespace RideAggrigateUI.DTO
{
        public class GetAllUserDataModel
        {
            public List<UserDataDTO> data { get; set; }
        }
        public class UserDataDTO
        {
            public int userid { get; set; }
            public string password { get; set; }
            public string email { get; set; }
            public string userrole { get; set; }
        }


    }

