Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionaConvidado("Lucas");
ep1.AdicionaConvidado("Pedro");
ep1.AdicionaConvidado("Andreia");

Episodio ep2 = new(1, "Desenvolvimento de Jogos", 45);
ep2.AdicionaConvidado("Romeu");
ep2.AdicionaConvidado("Jurandir");
ep2.AdicionaConvidado("Paloma");

Podcast podcast = new("Codando todo dia", "Silvio");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();