using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookManagementMemberRepository
    {
        BookManagement2023DbContext _context;
        //các hàm CRUD của table Member/Account

        //THẰNG REPO BAO GIỜ CŨNG CHƠI VỚI CSDL

        //hàm trả về 1 Account nào đó theo username/email - duy nhất trong table
        //do account thì email/user là duy nhất
        public BookManagementMember? Get(string email)
        {
            _context = new BookManagement2023DbContext();
            //db đang móc vào CSDL rồi. Có sẵn 3 table, list các data luôn rồi, chờ gọi xài
            return _context.BookManagementMembers.FirstOrDefault(x => x.Email == email);
        }
        public void InsertMember(BookManagementMember member)
        {
            _context = new BookManagement2023DbContext();
            if (_context.BookManagementMembers.Any())
            {
                int maxMemberId = _context.BookManagementMembers.Max(x => x.MemberId);
                member.MemberId = maxMemberId + 1;
            }
            else
            {

                return;
            }

            member.MemberRole = 3;
            _context.BookManagementMembers.Add(member);
            _context.SaveChanges();

        }

    }
}