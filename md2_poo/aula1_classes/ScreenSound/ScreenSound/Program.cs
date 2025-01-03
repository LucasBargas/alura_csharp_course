Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.DefineDisponivel(true);
Console.WriteLine(musica1.PegaDisponivel());

Musica musica2 = new Musica();
musica2.nome = "Fix You";
musica2.artista = "Coldplay";
musica2.duracao = 291;
musica2.DefineDisponivel(false);
Console.WriteLine(musica2.PegaDisponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();