using System;
using System.Collections.Generic;
using TvLicenceProject.Data;


namespace TvLicenceProject.Data
{
    public class UserDatabase
    {
        List<UserInfo> DataEntries = new List<UserInfo>();


            public bool CheckPresence (UserInfo User)
            {

                UserInfo Emily = new UserInfo();
                Emily.CourtDivision = "C1";
                Emily.UserSurname = "Bloggs";
                Emily.LicenceNumber = "12345678";
                Emily.UserFine = 150;
                DataEntries.Add(Emily);

                UserInfo Brian = new UserInfo();
                Brian.CourtDivision = "C2";
                Brian.UserSurname = "Bloggs";
                Brian.LicenceNumber = "12345678";
                Brian.UserFine = 100;
                DataEntries.Add(Brian);

                UserInfo Margret = new UserInfo();
                Margret.CourtDivision = "C3";
                Margret.UserSurname = "Bloggs";
                Margret.LicenceNumber = "12345678";
                Margret.UserFine = 0;
                DataEntries.Add(Margret);
                
                CompareCourtDivision compareCourt = new CompareCourtDivision();

                foreach(UserInfo ui in DataEntries)
                {
                    if(compareCourt.Equals(User, ui)==true)
                    {
                        return true;
                    }
                }

                return false;
            }


             public int FineReturn (UserInfo User)
            {
                
                CompareCourtDivision compareCourt = new CompareCourtDivision();

                foreach(UserInfo ui in DataEntries)
                {
                    if(compareCourt.Equals(User, ui)==true)
                    {
                        return ui.UserFine;
                    }
                }

                return -1;
            }


            public UserInfo UserReturn (UserInfo User)
            {
                UserInfo False = new UserInfo();
                CompareCourtDivision compareCourt = new CompareCourtDivision();

                foreach(UserInfo ui in DataEntries)
                {
                    if(compareCourt.Equals(User, ui)==true)
                    {
                        return ui;
                    }
                    return False;
                }

            }
    }

    public class CompareCourtDivision : IEqualityComparer<UserInfo>
    {

        public bool Equals(UserInfo u1, UserInfo u2)
        {
            return string.Equals(u1.CourtDivision, u2.CourtDivision, StringComparison.CurrentCultureIgnoreCase);
            
        }
        
        public int GetHashCode (UserInfo u1)
        {
            return u1.CourtDivision.GetHashCode();
        }

    }



}
