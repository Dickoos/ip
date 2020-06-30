using Npgsql;
using System;
using System.Collections.Generic;

namespace ip
{
    class DBHelper
    {
        readonly String cs = "Host=192.168.1.69;Username=pi;Password=23514317;Database=member"; // Ссылка на бд

        public List<String> GetGuestsOnMeet(string name, string date)
        {
            var listAllGuestsOnMeet = new List<String>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            // Команда для нужного нам поиска
            string sql;
            if (name != "" && date != "")
                sql = "select * from guests_list, guests_list_activity where guests_list_activity.id_full_name = guests_list.id and guests_list.full_name = '" + name + "' and guests_list_activity.date = '" + date + "'";
            else if (name != "")
                sql = "select * from guests_list, guests_list_activity where guests_list_activity.id_full_name = guests_list.id and guests_list.full_name = '" + name + "'";
            else if (date != "")
                sql = "select * from guests_list, guests_list_activity where guests_list_activity.id_full_name = guests_list.id and guests_list_activity.date = '" + date + "'";
            else
                sql = "select * from guests_list, guests_list_activity where guests_list_activity.id_full_name = guests_list.id";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                // Циферки в скобках - номера столбцов в таблице
                listAllGuestsOnMeet.Add(
                    rdr.GetString(1) + " Дата: " + rdr.GetString(7) +
                    " Номер: " + rdr.GetString(2) + " " +
                    (rdr.GetInt32(8) == 0 ? "(Не пришёл)" : "(Пришёл)") // Простая проверка пришёл/не пришёл
                    );
            }

            rdr.Close();
            cmd.Cancel();
            con.Close();
            return listAllGuestsOnMeet;
        }

        public List<String> GetMembersOnMeet(string name, string date)
        {
            var listAllMembersOnMeet = new List<String>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql;
            if (name != "" && date != "")
                sql = "select * from full_name_and_contacts, activity where activity.id_full_name = full_name_and_contacts.id and full_name_and_contacts.fullName = '" + name + "' and activity.date = '" + date + "'";
            else if (name != "")
                sql = "select * from full_name_and_contacts, activity where activity.id_full_name = full_name_and_contacts.id and full_name_and_contacts.fullName = '" + name + "'";
            else if (date != "")
                sql = "select * from full_name_and_contacts, activity where activity.id_full_name = full_name_and_contacts.id and activity.date = '" + date + "'";
            else
                sql = "select * from full_name_and_contacts, activity where activity.id_full_name = full_name_and_contacts.id";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listAllMembersOnMeet.Add(
                    rdr.GetString(1) + " (" + rdr.GetString(7) + ") Дата: " + rdr.GetString(6) +
                    " Номер: " + rdr.GetString(2) + " " +
                    (rdr.GetInt32(8) == 0 ? "(Не пришёл)" : "(Пришёл)")
                    );
            }

            rdr.Close();
            cmd.Cancel();
            con.Close();
            return listAllMembersOnMeet;
        }

        public List<string> GetGuests(string name)
        {
            var listAllGuest = new List<String>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql;
            if (name != "")
                sql = "select * from guests_list where full_name = '" + name + "'";
            else
                sql = "select * from guests_list";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listAllGuest.Add(
                    rdr.GetString(1) + " " + rdr.GetString(2) +
                    " " + rdr.GetString(3) + " " +
                    rdr.GetInt32(0));
            }

            rdr.Close();
            cmd.Cancel();
            con.Close();
            return listAllGuest;
        }

        public List<string> GetMembers(string name)
        {
            var listAllMembers = new List<String>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql;
            if (name != "")
                sql = "select * from full_name_and_contacts where fullName = '" + name + "'";
            else
                sql = "select * from full_name_and_contacts";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listAllMembers.Add(
                    rdr.GetString(1) + " " + rdr.GetString(2) +
                    " " + rdr.GetString(3) + " " +
                    rdr.GetInt32(0));
            }

            rdr.Close();
            cmd.Cancel();
            con.Close();
            return listAllMembers;
        }

        public void CheckUserNameAndUserDomainName(string userName, string userDomainName)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from compData where userName = '" + userName + "' and userDomainName = '" + userDomainName + "';";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // Если не нашлись записи
            if (!rdr.HasRows)
            {
                rdr.Close();
                cmd.Cancel();

                sql = "insert into compData values (DEFAULT, '" + userName + "', '" + userDomainName + "')";
                cmd = new NpgsqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Cancel();
            }

            rdr.Close();
            cmd.Cancel();
            con.Close();
        }

        public List<string> GetAllGuestNames()
        {
            var allGuestName = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                allGuestName.Add(rdr.GetString(1));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return allGuestName;
        }

        public List<string> GetAllMemberNames()
        {
            var allMemberName = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from full_name_and_contacts";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                allMemberName.Add(rdr.GetString(1));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return allMemberName;
        }

        public List<string> GetAllGuestNamesAndPhones()
        {
            var allGuestNameAndPhones = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                allGuestNameAndPhones.Add(rdr.GetString(1) + " (" + rdr.GetString(2) + ") " + rdr.GetInt32(0));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return allGuestNameAndPhones;
        }

        public List<string> GetAllMembersNamesAndPhones()
        {
            var allMembersNameAndPhones = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from full_name_and_contacts ";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
                allMembersNameAndPhones.Add(rdr.GetString(1) + " (" + rdr.GetString(2) + ") " + rdr.GetInt32(0));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return allMembersNameAndPhones;
        }

        public void SetWasOrNotGuests(string phoneNum, string date, string was)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list where phone_number = '" + phoneNum + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // Сначала мы находим пользователя по телефону (поэтому номер телефона так важен!)
            rdr.Read();
            var idFullName = rdr.GetInt32(0);
            rdr.Close();
            cmd.Cancel();

            if (was == "0")
                was = "1";
            else
                was = "0";

            sql = "update guests_list_activity set was = " + was + " where id_full_name = " + idFullName + " and date = '" + date + "'";
            cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            rdr.Close();
            cmd.Cancel();
            con.Close();
        }

        public void SetWasOrNotMembers(string phoneNum, string date, string was)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from full_name_and_contacts where phoneNumber = '" + phoneNum + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            var idFullName = rdr.GetInt32(0);
            rdr.Close();
            cmd.Cancel();

            if (was == "0")
                was = "1";
            else
                was = "0";

            sql = "update activity set was = " + was + " where id_full_name = " + idFullName + " and date = '" + date + "'";
            cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            rdr.Close();
            cmd.Cancel();
            con.Close();
        }

        public List<string> GetInformationAboutGuest(int id)
        {
            List<string> tempInformationList = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            // Забираем всю информацию о пользователе
            tempInformationList.Add(rdr.GetInt32(0).ToString());
            tempInformationList.Add(rdr.GetString(1));
            tempInformationList.Add(rdr.GetString(2));
            tempInformationList.Add(rdr.GetString(3));
            tempInformationList.Add(rdr.GetString(4));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return tempInformationList;
        }

        public List<string> GetInformationAboutMember(int id)
        {
            List<string> tempInformationList = new List<string>();

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from full_name_and_contacts where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            tempInformationList.Add(rdr.GetInt32(0).ToString());
            tempInformationList.Add(rdr.GetString(1));
            tempInformationList.Add(rdr.GetString(2));
            tempInformationList.Add(rdr.GetString(3));

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return tempInformationList;
        }

        public bool PhoneNumWasGuest(string phoneNum)
        {
            bool re;

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list where phone_number = '" + phoneNum + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            // Простая проверка того, есть ли номер в базе
            if (rdr.HasRows)
            {
                re = true;
            }
            else
                re = false;

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return re;
        }

        public bool PhoneNumWasMembers(string phoneNum)
        {
            bool re;

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from full_name_and_contacts where phoneNumber = '" + phoneNum + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                re = true;
            }
            else
                re = false;

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return re;
        }

        public bool MeetWas(int id, string date)
        {
            bool re;

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from guests_list_activity where id_full_name = " + id + " and date = '" + date + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            
            // Проверка на то, есть ли встреча уже на эту дату
            if (rdr.HasRows)
            {
                re = true;
            }
            else
                re = false;

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return re;
        }

        public bool MeetWasMember(int id, string date)
        {
            bool re;

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "select * from activity where id_full_name = " + id + " and date = '" + date + "'";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                re = true;
            }
            else
                re = false;

            rdr.Close();
            cmd.Cancel();
            con.Close();

            return re;
        }

        public void AddGuest(string fullName, string phoneNum, string email, string personalInformation)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "insert into guests_list values (DEFAULT, '" + fullName + "', '" + phoneNum + "', '" + email + "', '" + personalInformation + "')";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void AddMember(string fullName, string phoneNum, string email)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "insert into full_name_and_contacts values (DEFAULT, '" + fullName + "', '" + phoneNum + "', '" + email + "')";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void AddGuestOnMeet(int id, string date)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "insert into guests_list_activity values (DEFAULT, " + id + ", '" + date + "', " + 0 + ")";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void AddMemberOnMeet(int id, string position, string date)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "insert into activity values (DEFAULT, " + id + ", '" + date + "', '" + position + "', " + 0 + ")";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void UpdateGuestInformation(int id, string fullName, string phoneNum, string email, string personalInformation)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "update guests_list set full_name = '" + fullName + "', phone_number = '" + phoneNum + "', email = '" + email + "', personal_information = '" + personalInformation + "' where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void UpdateMemberInformation(int id, string fullName, string phoneNum, string email)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "update full_name_and_contacts set fullName = '" + fullName + "', phoneNumber = '" + phoneNum + "', email = '" + email + "' where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void DelGuest(int id)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            // Удаляем записи из списка гостей
            string sql = "delete from guests_list where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            // Удаляем все встречи
            sql = "delete from guests_list_activity where id_full_name = " + id;
            cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }

        public void DelMember(int id)
        {
            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "delete from full_name_and_contacts where id = " + id;
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            sql = "delete from activity where id_full_name = " + id;
            cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            cmd.Cancel();
            con.Close();
        }
    }
}
