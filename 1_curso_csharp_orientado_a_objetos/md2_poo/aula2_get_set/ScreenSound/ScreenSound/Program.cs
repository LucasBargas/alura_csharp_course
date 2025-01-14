Album albumDoQueen = new("A Night At The Opera"); 
Banda queen = new("Queen");

Musica musica1 = new(queen, "Love of my Life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

// Desafio
