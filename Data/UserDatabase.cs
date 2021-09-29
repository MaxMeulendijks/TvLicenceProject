using System;
using System.Collections.IList;

namespace TvLicenceProject.Data
{
    public class UserDatabase
    {
            public int CheckPresence (UserInfo User)
            {
                ArrayList<UserInfo> DataEntries = new ArrayList<UserInfo>();

                UserInfo Emily = new UserInfo();
                Emily.CourtDivision = "C1";
                Emily.UserFine = 150;

                UserInfo Brian = new UserInfo();
                Brian.CourtDivision = "C2";
                Brian.UserFine = 100;

                UserInfo Margret = new UserInfo();
                Margret.CourtDivision = "C3";
                Margret.UserFine = 0;

                foreach(Userinfo ui in DataEntries)
                {
                    if(CompareCourtDivision(User, ui)==0)
                    {
                        return ui.UserFine;
                    }
                }

                return -1;
            }
    }
}
