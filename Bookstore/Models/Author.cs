﻿using System;
using System.Collections.Generic;

namespace Bookstore.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorFirst { get; set; } = null!;

    public string AuthorLast { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
