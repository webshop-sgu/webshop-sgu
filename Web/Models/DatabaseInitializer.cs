using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Role administrator = new Role { Name = "Quản trị viên" };
            Role manager = new Role { Name = "Quản lí" };
            Role customer = new Role { Name = "Khách hàng" };

            var roles = new List<Role>
            {
                administrator,
                manager,
                customer
            };
            roles.ForEach(r => context.Roles.Add((r)));
            context.SaveChanges();

            User admin = new User { Username = "admin", Password = "21232f297a57a5a743894a0e4a801fc3", Birthday = new DateTime(1991, 4, 21), Email = "admin@gmail.com", RealName = "Administrator", Role = administrator, Tel = "0123456789" };
            User nguyenbinh07 = new User { Username = "nguyenbinh07", Password = "f5768c6df10779b5dbd4402533a5403a", Birthday = new DateTime(1991, 5, 22), Email = "nguyenbinh07@gmail.com", RealName = "Mr. Bình", Role = manager, Tel = "1234567890" };
            User quangpropk = new User { Username = "quangpropk", Password = "68734de9277690976b8c34ddba01ca31", Birthday = new DateTime(1992, 6, 23), Email = "quangpropk@gmail.com", RealName = "Mr. Quang", Role = manager, Tel = "2345678901" };
            User customerUser = new User { Username = "customer", Password = "91ec1f9324753048c0096d036a694f86", Birthday = new DateTime(1993, 7, 24), Email = "customer@gmail.com", RealName = "Mr. Khách Hàng", Role = customer, Tel = "3456789013" };
            var users = new List<User>
            {
                admin,
                nguyenbinh07,
                quangpropk,
                customerUser
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            Log log_admin = new Log { Message = "Khởi động tài khoản", Time = new DateTime(2013, 9, 1), User = admin };
            Log log_admin_new_users = new Log { Message = "Tạo một đống tài khoản", Time = new DateTime(2013, 9, 1), User = admin };
            Log log_binh = new Log { Message = "Khởi động tài khoản", Time = new DateTime(2013, 9, 1), User = nguyenbinh07 };
            var logs = new List<Log>
            {
                log_admin,
                log_admin_new_users,
                log_binh
            };
            logs.ForEach(l => context.Logs.Add(l));
            context.SaveChanges();
        }
    }
}