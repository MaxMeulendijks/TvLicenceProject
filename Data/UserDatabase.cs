using System;
using System.Collections.Generic;
using TvLicenceProject.Data;


namespace TvLicenceProject.Data
{
    public class UserDatabase
    {
            public int CheckPresence (UserInfo User)
            {
                List<UserInfo> DataEntries = new List<UserInfo>();

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

                foreach(UserInfo ui in DataEntries)
                {
                    if(CompareUser.CompareCourtDivision(User, ui)==true)
                    {
                        return ui.UserFine;
                    }
                }

                return -1;
            }
    }
}
