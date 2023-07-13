using System;
using System.Collections.Generic;

namespace ButonStore.Models;

public partial class UserLoginDetail
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
