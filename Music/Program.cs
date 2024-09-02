Episodio ep1 = new(2, "Tecnicas de facilitação", 45);
ep1.AdicionarConvidados("Robs");
ep1.AdicionarConvidados("José");

Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Fernando");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();