using System;
using System.Collections.IList;
inject UserInfo User;

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
                DataEntries.Add(Emily);

                UserInfo Brian = new UserInfo();
                Brian.CourtDivision = "C2";
                Brian.UserFine = 100;
                DataEntries.Add(Brian);

                UserInfo Margret = new UserInfo();
                Margret.CourtDivision = "C3";
                Margret.UserFine = 0;
                DataEntries.Add(Margret);

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
