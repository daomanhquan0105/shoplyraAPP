namespace ShopLyraAPP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [MetadataTypeAttribute(typeof(MemberMetaData))]
    public partial class Member
    {
        internal sealed class MemberMetaData
        {
            public long ID { get; set; }
            [DisplayName("Tài khoản"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy điền thông tin cho tài khoản")]
            [StringLength(32,ErrorMessage ="Tài khoản phải từ 6-32 ký tự",MinimumLength =6)]
            [RegularExpression(@"[a-z0-9]{4,10}", ErrorMessage = "Chỉ nhập chữ thường và số 0-9, từ 4-10 ký tự")]
            public string Account { get; set; }

            [DisplayName("Mật khẩu"),UIHint("PassWord")]
            [Required(ErrorMessage ="Hãy nhập mật khẩu")]
            [StringLength(32, ErrorMessage = "Tài khoản phải từ 6-32 ký tự", MinimumLength = 6)]
            [RegularExpression(@"[a-z0-9]{4,10}", ErrorMessage = "Chỉ nhập chữ thường và số 0-9, từ 4-10 ký tự")]
            public string Pssword { get; set; }

            [DisplayName("Tên Người tạo")]
            [Required(ErrorMessage ="Hãy điền tên của bạn")]
            [StringLength(100)]
            public string Name { get; set; }

            [DisplayName("Số điện thoại"),UIHint("TextBox")]
            [Required(ErrorMessage ="hãy nhập số điện thoại"),Phone(ErrorMessage ="Phải là số nguyên")]
            public string Phone { get; set; }

            [DisplayName("Email"),UIHint("TextBox")]
            [Required(ErrorMessage ="Hãy nhập email của bạn"),EmailAddress(ErrorMessage ="Hãy nhập đúng email")]
            [StringLength(250)]
            public string Email { get; set; }

            [DisplayName("Địa chỉ")]
            [StringLength(250)]
            public string Address { get; set; }

            [DisplayName("Loại thành viên")]
            public int IDCategory { get; set; }
        }
    }
}
