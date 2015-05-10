using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public enum MemberLevel
    {
        Member,
        Admin
    }

    public class MemberViewModel
    {
        public string MemberId { get; set; }
        public string MemberPw { get; set; }
        [UIHint("Enum-radio")]
        public MemberLevel Level { get; set; }
    }
}