using System;
using System.Collections.Generic;

namespace ButonStore.DbEntityClasses;

public partial class UserLoginDetail
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long Id { get; set; }
}
