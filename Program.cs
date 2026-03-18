Library lib = new();

Book book1  = new("donaldlend", 1982, "Yulia");
Book book2 = new("lalalend", 1345, "Kira");

Journal journal1 = new("IKira", 2008, 98-90);
Journal journal2 = new("IMArk", 2011, 6565-32);

Video video1 = new("edi", 2026, 67);
Video video2 = new("ebbbi", 2026, 87);

lib.Add(book1);
lib.Add(book2);
lib.Add(journal1);
lib.Add(journal2);
lib.Add(video1);
lib.Add(video2);

lib.ShowMaterial();
lib.PerformActions();
lib.SearchByYear(2008);