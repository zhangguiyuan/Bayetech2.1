
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Bayetech.DAL.Entity
{

using System;
    using System.Collections.Generic;
    
public partial class Login
{

    public long Logid { get; set; }

    public string UserName { get; set; }

    public string PassWord { get; set; }

    public Nullable<byte> Admin { get; set; }

    public string LoginIp { get; set; }

    public Nullable<int> LoginTime { get; set; }

    public string Message { get; set; }

    public string Agent { get; set; }

}

}
