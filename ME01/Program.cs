using ME01.model;
using System;
using System.Collections.Generic;

class GerenciadorOrquestra
{
    private List<Evento> eventos = new List<Evento>();
    private List<Concerto> concertos = new List<Concerto>();
    private List<Ensaios> ensaios = new List<Ensaios>();
    private List<Espectadores> espectadores = new List<Espectadores>();
    private List<Ingressos> ingressos = new List<Ingressos>();
    private List<Instrumento> instrumentos = new List<Instrumento>();
    private List<LocalApresentacao> locais = new List<LocalApresentacao>();
    private List<Maestro> maestros = new List<Maestro>();
    private List<Musicas> musicas = new List<Musicas>();
    private List<Musico> musicos = new List<Musico>();

    private int LerInteiro(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
    }

    private string LerString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private double LerDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double valor))
                return valor;
            Console.WriteLine("Entrada inválida. Digite um número decimal.");
        }
    }

    private DateTime LerDateTime(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (DateTime.TryParse(Console.ReadLine(), out DateTime valor))
                return valor;
            Console.WriteLine("Entrada inválida. Use o formato yyyy-mm-dd.");
        }
    }

    private TimeSpan LerTimeSpan(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan valor))
                return valor;
            Console.WriteLine("Entrada inválida. Use o formato hh:mm.");
        }
    }

    public void Iniciar()
    {
        while (true)
        {
            Console.WriteLine("\n=== Menu Principal ===");
            Console.WriteLine("1. Gerenciar Eventos");
            Console.WriteLine("2. Gerenciar Concertos");
            Console.WriteLine("3. Gerenciar Ensaios");
            Console.WriteLine("4. Gerenciar Espectadores");
            Console.WriteLine("5. Gerenciar Ingressos");
            Console.WriteLine("6. Gerenciar Instrumentos");
            Console.WriteLine("7. Gerenciar Locais de Apresentação");
            Console.WriteLine("8. Gerenciar Maestros");
            Console.WriteLine("9. Gerenciar Músicas");
            Console.WriteLine("10. Gerenciar Músicos");
            Console.WriteLine("11. Preencher dados");
            Console.WriteLine("12. Sair");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: GerenciarEventos(); break;
                case 2: GerenciarConcertos(); break;
                case 3: GerenciarEnsaios(); break;
                case 4: GerenciarEspectadores(); break;
                case 5: GerenciarIngressos(); break;
                case 6: GerenciarInstrumentos(); break;
                case 7: GerenciarLocais(); break;
                case 8: GerenciarMaestros(); break;
                case 9: GerenciarMusicas(); break;
                case 10: GerenciarMusicos(); break;
                case 11: PreencherDados(); break;
                case 12: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void PreencherDados()
    {
        locais.Add(new LocalApresentacao("Teatro Municipal", 1500, "São Paulo", "Praça Ramos de Azevedo, s/n", "Teatro", 1911));
        locais.Add(new LocalApresentacao("Auditório Ibirapuera", 800, "São Paulo", "Av. Pedro Álvares Cabral, 0", "Auditório", 2005));
        locais.Add(new LocalApresentacao("Sala São Paulo", 1484, "São Paulo", "Praça Júlio Prestes, 16", "Sala de Concerto", 1999));
        locais.Add(new LocalApresentacao("Centro Cultural Banco do Brasil", 100, "Rio de Janeiro", "Rua Primeiro de Março, 66", "Centro Cultural", 1989));
        locais.Add(new LocalApresentacao("Teatro Amazonas", 701, "Manaus", "Largo de São Sebastião, s/n", "Teatro", 1896));
        locais.Add(new LocalApresentacao("Ópera de Arame", 1572, "Curitiba", "Rua João Gava, 920", "Ópera", 1992));
        locais.Add(new LocalApresentacao("Arena do IMB", 5000, "Brasília", "Setor de Clubes Esportivos Sul", "Arena", 2010));
        locais.Add(new LocalApresentacao("Teatro Castro Alves", 1631, "Salvador", "Praça Dois de Julho, s/n", "Teatro", 1958));
        locais.Add(new LocalApresentacao("Theatro José de Alencar", 1200, "Fortaleza", "Rua Liberato Barroso, 525", "Teatro", 1910));
        locais.Add(new LocalApresentacao("Palácio das Artes", 1660, "Belo Horizonte", "Av. Afonso Pena, 1537", "Centro Cultural", 1971));

        eventos.Add(new Evento("Noite de Beethoven", "Concerto Sinfônico", new DateTime(2025, 6, 10), new TimeSpan(19, 30, 0), "Uma noite dedicada às obras de Beethoven.", locais[0]));
        eventos.Add(new Evento("Mozart e sua Magia", "Concerto Clássico", new DateTime(2025, 7, 15), new TimeSpan(20, 00, 0), "Apresentação das sinfonias mais famosas de Mozart.", locais[1]));
        eventos.Add(new Evento("A Grande Sinfonia", "Concerto", new DateTime(2025, 8, 5), new TimeSpan(18, 45, 0), "Uma experiência emocionante com Tchaikovsky e Brahms.", locais[2]));
        eventos.Add(new Evento("Vivaldi: As Quatro Estações", "Concerto Barroco", new DateTime(2025, 9, 12), new TimeSpan(19, 00, 0), "Uma apresentação vibrante das Quatro Estações de Vivaldi.", locais[3]));
        eventos.Add(new Evento("Sinfonia do Novo Mundo", "Concerto Orquestral", new DateTime(2025, 10, 3), new TimeSpan(21, 00, 0), "Uma jornada sonora com Dvořák.", locais[4]));
        eventos.Add(new Evento("O Melhor de Chopin", "Recital de Piano", new DateTime(2025, 11, 20), new TimeSpan(18, 30, 0), "Uma noite especial com as obras de Chopin.", locais[5]));
        eventos.Add(new Evento("Ópera Gala", "Gala de Ópera", new DateTime(2025, 12, 1), new TimeSpan(20, 30, 0), "Os maiores trechos de óperas clássicas interpretados por grandes solistas.", locais[6]));
        eventos.Add(new Evento("Cinema em Concerto", "Concerto Temático", new DateTime(2026, 1, 18), new TimeSpan(19, 45, 0), "Uma apresentação orquestral de trilhas sonoras icônicas do cinema.", locais[7]));
        eventos.Add(new Evento("Bach: O Mestre do Barroco", "Concerto de Música Barroca", new DateTime(2026, 2, 10), new TimeSpan(18, 00, 0), "Uma imersão no legado de Johann Sebastian Bach.", locais[8]));
        eventos.Add(new Evento("A Magia do Bolero", "Concerto Especial", new DateTime(2026, 3, 25), new TimeSpan(20, 00, 0), "A famosa peça de Ravel e outras obras impressionistas.", locais[9]));

        concertos.Add(new Concerto(new DateTime(2025, 4, 10), new TimeSpan(2, 0, 0), locais[0], "Beethoven: Sinfonia nº 5, Mozart: Abertura de Don Giovanni", "Maestro Carlos Lima", 500, 480));
        concertos.Add(new Concerto(new DateTime(2025, 4, 17), new TimeSpan(1, 30, 0), locais[1], "Bach: Concerto de Brandemburgo nº 3, Vivaldi: As Quatro Estações", "Maestrina Ana Ribeiro", 600, 580));
        concertos.Add(new Concerto(new DateTime(2025, 4, 24), new TimeSpan(1, 40, 0), locais[2], "John Williams: Star Wars, Ennio Morricone: Cinema Paradiso", "Maestro Roberto Nunes", 700, 690));
        concertos.Add(new Concerto(new DateTime(2025, 4, 27), new TimeSpan(1, 0, 0), locais[3], "Saint-Saëns: Carnaval dos Animais, Prokofiev: Pedro e o Lobo", "Maestro Daniel Soares", 300, 290));
        concertos.Add(new Concerto(new DateTime(2025, 5, 1), new TimeSpan(1, 50, 0), locais[4], "Tchaikovsky: Romeu e Julieta, Brahms: Sinfonia nº 1", "Maestrina Helena Duarte", 450, 430));
        concertos.Add(new Concerto(new DateTime(2025, 5, 8), new TimeSpan(2, 0, 0), locais[5], "Sibelius: Concerto para Violino, Rachmaninoff: Concerto para Piano nº 2", "Maestro Eduardo Vasconcelos", 550, 530));
        concertos.Add(new Concerto(new DateTime(2025, 5, 15), new TimeSpan(1, 30, 0), locais[6], "Música de câmara com poesia de Fernando Pessoa e Cecília Meireles", "Maestro João Mendes", 400, 380));
        concertos.Add(new Concerto(new DateTime(2025, 5, 22), new TimeSpan(1, 20, 0), locais[7], "Clássicos populares: Strauss, Elgar, Bizet", "Maestro Lucas Tavares", 1000, 950));
        concertos.Add(new Concerto(new DateTime(2025, 5, 29), new TimeSpan(1, 40, 0), locais[8], "Gershwin: Rhapsody in Blue, Ellington: Harlem", "Maestrina Marina Leão", 600, 590));
        concertos.Add(new Concerto(new DateTime(2025, 6, 5), new TimeSpan(2, 10, 0), locais[9], "Beethoven: Sinfonia nº 9", "Maestro Carlos Lima", 700, 700));

        ensaios.Add(new Ensaios(new DateTime(2025, 6, 10), new TimeSpan(14, 00, 0), new TimeSpan(3, 0, 0), locais[0], "Sinfonia nº 9 - Beethoven", "João Silva"));
        ensaios.Add(new Ensaios(new DateTime(2025, 7, 15), new TimeSpan(15, 30, 0), new TimeSpan(2, 30, 0), locais[1], "Requiem - Mozart", "Carlos Oliveira"));
        ensaios.Add(new Ensaios(new DateTime(2025, 8, 5), new TimeSpan(13, 45, 0), new TimeSpan(3, 0, 0), locais[2], "O Lago dos Cisnes - Tchaikovsky", "Ana Souza"));
        ensaios.Add(new Ensaios(new DateTime(2025, 9, 12), new TimeSpan(14, 15, 0), new TimeSpan(2, 0, 0), locais[3], "As Quatro Estações - Vivaldi", "Ricardo Mendes"));
        ensaios.Add(new Ensaios(new DateTime(2025, 10, 3), new TimeSpan(16, 00, 0), new TimeSpan(2, 45, 0), locais[4], "Sinfonia do Novo Mundo - Dvořák", "Fernanda Lima"));
        ensaios.Add(new Ensaios(new DateTime(2025, 11, 20), new TimeSpan(13, 30, 0), new TimeSpan(2, 15, 0), locais[0], "Concerto para Piano nº 1 - Chopin", "Mariana Rocha"));
        ensaios.Add(new Ensaios(new DateTime(2025, 12, 1), new TimeSpan(15, 00, 0), new TimeSpan(2, 30, 0), locais[1], "Trechos de Óperas Famosas", "Eduardo Castro"));
        ensaios.Add(new Ensaios(new DateTime(2026, 1, 18), new TimeSpan(14, 45, 0), new TimeSpan(3, 0, 0), locais[2], "Trilhas Sonoras de Filmes", "Gabriel Nunes"));
        ensaios.Add(new Ensaios(new DateTime(2026, 2, 10), new TimeSpan(13, 00, 0), new TimeSpan(2, 0, 0), locais[3], "As Obras de Bach", "Sérgio Almeida"));
        ensaios.Add(new Ensaios(new DateTime(2026, 3, 25), new TimeSpan(16, 30, 0), new TimeSpan(2, 30, 0), locais[4], "Bolero de Ravel", "Lucas Martins"));

        espectadores.Add(new Espectadores("Ana Souza", 25, "Normal", "A12", 120.00));
        espectadores.Add(new Espectadores("Carlos Oliveira", 32, "VIP", "B05", 250.00));
        espectadores.Add(new Espectadores("Fernanda Lima", 19, "Estudante", "C22", 60.00));
        espectadores.Add(new Espectadores("João Mendes", 45, "Normal", "D10", 120.00));
        espectadores.Add(new Espectadores("Mariana Rocha", 28, "VIP", "A01", 300.00));
        espectadores.Add(new Espectadores("Ricardo Alves", 21, "Estudante", "E15", 60.00));
        espectadores.Add(new Espectadores("Sérgio Almeida", 38, "Normal", "F08", 130.00));
        espectadores.Add(new Espectadores("Gabriel Nunes", 50, "VIP", "G02", 280.00));
        espectadores.Add(new Espectadores("Eduardo Castro", 22, "Estudante", "H14", 70.00));
        espectadores.Add(new Espectadores("Laura Martins", 30, "Normal", "I09", 110.00));

        ingressos.Add(new Ingressos("VIP", 250.00, 101, "A12"));
        ingressos.Add(new Ingressos("Normal", 120.00, 102, "B05"));
        ingressos.Add(new Ingressos("Estudante", 60.00, 103, "C22"));
        ingressos.Add(new Ingressos("Normal", 130.00, 104, "D10"));
        ingressos.Add(new Ingressos("VIP", 300.00, 105, "A01"));
        ingressos.Add(new Ingressos("Estudante", 60.00, 106, "E15"));
        ingressos.Add(new Ingressos("Normal", 130.00, 107, "F08"));
        ingressos.Add(new Ingressos("VIP", 280.00, 108, "G02"));
        ingressos.Add(new Ingressos("Estudante", 70.00, 109, "H14"));
        ingressos.Add(new Ingressos("Normal", 110.00, 110, "I09"));

        instrumentos.Add(new Instrumento("Violino Stradivarius", "Cordas", "Stradivari", 1721, "Madeira", 15000000.00));
        instrumentos.Add(new Instrumento("Piano Steinway & Sons", "Cordas", "Steinway & Sons", 2020, "Madeira e Metal", 120000.00));
        instrumentos.Add(new Instrumento("Flauta Yamaha YFL-222", "Sopro", "Yamaha", 2019, "Prata", 3000.00));
        instrumentos.Add(new Instrumento("Clarinete Buffet Crampon", "Sopro", "Buffet Crampon", 2018, "Madeira de Grenadilla", 4500.00));
        instrumentos.Add(new Instrumento("Trompete Bach Stradivarius", "Sopro", "Bach", 2021, "Latão", 3500.00));
        instrumentos.Add(new Instrumento("Harpa Lyon & Healy Style 23", "Cordas", "Lyon & Healy", 2015, "Madeira", 55000.00));
        instrumentos.Add(new Instrumento("Bateria Pearl Export", "Percussão", "Pearl", 2022, "Madeira e Metal", 7000.00));
        instrumentos.Add(new Instrumento("Contrabaixo Fender Jazz Bass", "Cordas", "Fender", 2017, "Madeira", 8500.00));
        instrumentos.Add(new Instrumento("Oboé Loree Royal", "Sopro", "Loree", 2016, "Madeira de Ébano", 12000.00));
        instrumentos.Add(new Instrumento("Tímpano Adams Professional", "Percussão", "Adams", 2023, "Cobre e Madeira", 15000.00));

        maestros.Add(new Maestro("João Silva", 55, "Música Clássica", 30, 15000.00, "Brasileiro"));
        maestros.Add(new Maestro("Carlos Oliveira", 48, "Ópera", 25, 14000.00, "Português"));
        maestros.Add(new Maestro("Ana Souza", 42, "Jazz", 20, 13500.00, "Brasileira"));
        maestros.Add(new Maestro("Ricardo Mendes", 60, "Música Barroca", 35, 16000.00, "Espanhol"));
        maestros.Add(new Maestro("Fernanda Lima", 39, "Música Contemporânea", 18, 12000.00, "Argentina"));
        maestros.Add(new Maestro("Mariana Rocha", 50, "Música Romântica", 28, 14500.00, "Francesa"));
        maestros.Add(new Maestro("Eduardo Castro", 45, "Música Clássica", 22, 13800.00, "Italiano"));
        maestros.Add(new Maestro("Gabriel Nunes", 53, "Ópera", 29, 15500.00, "Alemão"));
        maestros.Add(new Maestro("Sérgio Almeida", 47, "Jazz", 23, 13200.00, "Inglês"));
        maestros.Add(new Maestro("Lucas Martins", 58, "Música Erudita", 33, 15800.00, "Austríaco"));

        musicas.Add(new Musicas("Sinfonia nº 9", "Ludwig van Beethoven", new TimeSpan(1, 10, 0), 1824, "Clássico", "Violino, Viola, Violoncelo, Contrabaixo, Trompete, Trombone, Tímpano"));
        musicas.Add(new Musicas("Requiem", "Wolfgang Amadeus Mozart", new TimeSpan(0, 55, 0), 1791, "Clássico", "Órgão, Coro, Violino, Viola, Violoncelo, Contrabaixo"));
        musicas.Add(new Musicas("O Lago dos Cisnes", "Pyotr Ilyich Tchaikovsky", new TimeSpan(2, 5, 0), 1876, "Romântico", "Violino, Viola, Violoncelo, Contrabaixo, Harpa, Flauta, Clarinete"));
        musicas.Add(new Musicas("As Quatro Estações", "Antonio Vivaldi", new TimeSpan(0, 42, 0), 1723, "Barroco", "Violino, Viola, Violoncelo, Contrabaixo, Cravo"));
        musicas.Add(new Musicas("Sinfonia do Novo Mundo", "Antonín Dvořák", new TimeSpan(0, 40, 0), 1893, "Romântico", "Violino, Viola, Violoncelo, Contrabaixo, Trompete, Trombone, Clarinete"));
        musicas.Add(new Musicas("Concerto para Piano nº 1", "Frédéric Chopin", new TimeSpan(0, 42, 0), 1830, "Romântico", "Piano, Violino, Viola, Violoncelo, Contrabaixo"));
        musicas.Add(new Musicas("Bolero", "Maurice Ravel", new TimeSpan(0, 15, 0), 1928, "Impressionista", "Flauta, Clarinete, Oboé, Trompete, Trombone, Percussão"));
        musicas.Add(new Musicas("Tristão e Isolda - Prelúdio", "Richard Wagner", new TimeSpan(0, 12, 0), 1859, "Romântico", "Violino, Viola, Violoncelo, Contrabaixo, Trombone, Trompete"));
        musicas.Add(new Musicas("Canon em Ré Maior", "Johann Pachelbel", new TimeSpan(0, 6, 0), 1680, "Barroco", "Violino, Viola, Violoncelo, Cravo"));
        musicas.Add(new Musicas("Rhapsody in Blue", "George Gershwin", new TimeSpan(0, 16, 0), 1924, "Jazz Sinfônico", "Piano, Clarinete, Trompete, Violino, Viola, Violoncelo, Contrabaixo"));

        musicos.Add(new Musico("Pedro Almeida", 35, "Violino", 15, 7500.00, "Solista"));
        musicos.Add(new Musico("Mariana Costa", 28, "Piano", 10, 6800.00, "Acompanhante"));
        musicos.Add(new Musico("Ricardo Santos", 40, "Trompete", 18, 7200.00, "Sectionista"));
        musicos.Add(new Musico("Ana Beatriz", 32, "Flauta", 12, 6900.00, "Solista"));
        musicos.Add(new Musico("Gustavo Ferreira", 45, "Clarinete", 20, 7700.00, "Sectionista"));
        musicos.Add(new Musico("Laura Nascimento", 30, "Harpa", 11, 7100.00, "Solista"));
        musicos.Add(new Musico("Carlos Mendes", 38, "Violoncelo", 17, 7400.00, "Sectionista"));
        musicos.Add(new Musico("Fernanda Oliveira", 29, "Oboé", 9, 6700.00, "Sectionista"));
        musicos.Add(new Musico("Lucas Ribeiro", 50, "Contrabaixo", 25, 8000.00, "Solista"));
        musicos.Add(new Musico("Tatiane Duarte", 27, "Percussão", 8, 6600.00, "Sectionista"));

        Console.WriteLine("Dados preenchidos com sucesso!");
    }

    private void GerenciarEventos()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Eventos ===");
            Console.WriteLine("1. Criar Evento");
            Console.WriteLine("2. Listar Eventos");
            Console.WriteLine("3. Atualizar Evento");
            Console.WriteLine("4. Deletar Evento");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarEvento(); break;
                case 2: ListarEventos(); break;
                case 3: AtualizarEvento(); break;
                case 4: DeletarEvento(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarEvento()
    {
        string nome = LerString("Nome: ");
        string tipo = LerString("Tipo: ");
        DateTime data = LerDateTime("Data (yyyy-mm-dd): ");
        TimeSpan hora = LerTimeSpan("Hora (hh:mm): ");
        string descricao = LerString("Descrição: ");

        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum Local cadastrado, cadastre um local!");

            CriarLocal();
        }
        ListarLocais();
        int idLocal = LerInteiro("Selecione um local para o novo evento: ") - 1;

        eventos.Add(new Evento(nome, tipo, data, hora, descricao, locais[idLocal]));
        Console.WriteLine($"Evento criado com sucesso no local {locais[idLocal].Nome}!");
    }

    private void ListarEventos()
    {
        if (eventos.Count == 0)
        {
            Console.WriteLine("Nenhum evento cadastrado.");
            return;
        }
        for (int i = 0; i < eventos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {eventos[i].Nome} - {eventos[i].Data.ToShortDateString()}");
        }
    }

    private void AtualizarEvento()
    {
        if (eventos.Count == 0)
        {
            Console.WriteLine("Nenhum evento para atualizar.");
            return;
        }
        ListarEventos();
        int idx = LerInteiro("Selecione o evento a atualizar: ") - 1;
        if (idx >= 0 && idx < eventos.Count)
        {
            Evento evento = eventos[idx];
            string nome = LerString($"Novo nome ({evento.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) evento.Nome = nome;
            Console.WriteLine("Evento atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarEvento()
    {
        if (eventos.Count == 0)
        {
            Console.WriteLine("Nenhum evento para deletar.");
            return;
        }
        ListarEventos();
        int idx = LerInteiro("Selecione o evento a deletar: ") - 1;
        if (idx >= 0 && idx < eventos.Count)
        {
            eventos.RemoveAt(idx);
            Console.WriteLine("Evento deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarConcertos()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Concertos ===");
            Console.WriteLine("1. Criar Concerto");
            Console.WriteLine("2. Listar Concertos");
            Console.WriteLine("3. Atualizar Concerto");
            Console.WriteLine("4. Deletar Concerto");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarConcerto(); break;
                case 2: ListarConcertos(); break;
                case 3: AtualizarConcerto(); break;
                case 4: DeletarConcerto(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarConcerto()
    {
        DateTime data = LerDateTime("Data (yyyy-mm-dd): ");
        TimeSpan duracao = LerTimeSpan("Duração (hh:mm): ");

        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum Local cadastrado, cadastre um local!");

            CriarLocal();
        }
        ListarLocais();
        int idLocal = LerInteiro("Selecione um local para o novo evento: ") - 1;

        string repertorio = LerString("Repertório: ");
        string maestro = LerString("Maestro: ");
        int ingressosDisponiveis = LerInteiro("Ingressos Disponíveis: ");
        int espectadoresPresentes = LerInteiro("Espectadores Presentes: ");
        concertos.Add(new Concerto(data, duracao, locais[idLocal], repertorio, maestro, ingressosDisponiveis, espectadoresPresentes));
        Console.WriteLine("Concerto criado com sucesso!");
    }

    private void ListarConcertos()
    {
        if (concertos.Count == 0)
        {
            Console.WriteLine("Nenhum concerto cadastrado.");
            return;
        }
        for (int i = 0; i < concertos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {concertos[i].Repertorio} - {concertos[i].Data.ToShortDateString()}");
        }
    }

    private void AtualizarConcerto()
    {
        if (concertos.Count == 0)
        {
            Console.WriteLine("Nenhum concerto para atualizar.");
            return;
        }
        ListarConcertos();
        int idx = LerInteiro("Selecione o concerto a atualizar: ") - 1;
        if (idx >= 0 && idx < concertos.Count)
        {
            Concerto concerto = concertos[idx];
            string repertorio = LerString($"Novo repertório ({concerto.Repertorio}): ");
            if (!string.IsNullOrEmpty(repertorio)) concerto.Repertorio = repertorio;
            Console.WriteLine("Concerto atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarConcerto()
    {
        if (concertos.Count == 0)
        {
            Console.WriteLine("Nenhum concerto para deletar.");
            return;
        }
        ListarConcertos();
        int idx = LerInteiro("Selecione o concerto a deletar: ") - 1;
        if (idx >= 0 && idx < concertos.Count)
        {
            concertos.RemoveAt(idx);
            Console.WriteLine("Concerto deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarEnsaios()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Ensaios ===");
            Console.WriteLine("1. Criar Ensaio");
            Console.WriteLine("2. Listar Ensaios");
            Console.WriteLine("3. Atualizar Ensaio");
            Console.WriteLine("4. Deletar Ensaio");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarEnsaio(); break;
                case 2: ListarEnsaios(); break;
                case 3: AtualizarEnsaio(); break;
                case 4: DeletarEnsaio(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarEnsaio()
    {
        DateTime data = LerDateTime("Data (yyyy-mm-dd): ");
        TimeSpan hora = LerTimeSpan("Hora (hh:mm): ");
        TimeSpan duracao = LerTimeSpan("Duração (hh:mm): ");
        string repertorio = LerString("Repertório: ");
        string maestro = LerString("Maestro: ");

        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum Local cadastrado, cadastre um local!");

            CriarLocal();
        }
        ListarLocais();
        int idLocal = LerInteiro("Selecione um local para o novo evento: ") - 1;

        ensaios.Add(new Ensaios(data, hora, duracao, locais[idLocal], repertorio, maestro));
        Console.WriteLine("Ensaio criado com sucesso!");
    }
    private void ListarEnsaios()
    {
        if (ensaios.Count == 0)
        {
            Console.WriteLine("Nenhum ensaio cadastrado.");
            return;
        }
        for (int i = 0; i < ensaios.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ensaios[i].Repertorio} - {ensaios[i].Data.ToShortDateString()}");
        }
    }

    private void AtualizarEnsaio()
    {
        if (ensaios.Count == 0)
        {
            Console.WriteLine("Nenhum ensaio para atualizar.");
            return;
        }
        ListarEnsaios();
        int idx = LerInteiro("Selecione o ensaio a atualizar: ") - 1;
        if (idx >= 0 && idx < ensaios.Count)
        {
            Ensaios ensaio = ensaios[idx];
            string repertorio = LerString($"Novo repertório ({ensaio.Repertorio}): ");
            if (!string.IsNullOrEmpty(repertorio)) ensaio.Repertorio = repertorio;
            Console.WriteLine("Ensaio atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarEnsaio()
    {
        if (ensaios.Count == 0)
        {
            Console.WriteLine("Nenhum ensaio para deletar.");
            return;
        }
        ListarEnsaios();
        int idx = LerInteiro("Selecione o ensaio a deletar: ") - 1;
        if (idx >= 0 && idx < ensaios.Count)
        {
            ensaios.RemoveAt(idx);
            Console.WriteLine("Ensaio deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarEspectadores()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Espectadores ===");
            Console.WriteLine("1. Criar Espectador");
            Console.WriteLine("2. Listar Espectadores");
            Console.WriteLine("3. Atualizar Espectador");
            Console.WriteLine("4. Deletar Espectador");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarEspectador(); break;
                case 2: ListarEspectadores(); break;
                case 3: AtualizarEspectador(); break;
                case 4: DeletarEspectador(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarEspectador()
    {
        string nome = LerString("Nome: ");
        int idade = LerInteiro("Idade: ");
        string tipo = LerString("Tipo ingresso: ");
        string assento = LerString("Assento: ");
        double pagamento = LerDouble("Pagamento: ");

        espectadores.Add(new Espectadores(nome, idade, tipo, assento, pagamento));
        Console.WriteLine("Espectador criado com sucesso!");
    }

    private void ListarEspectadores()
    {
        if (espectadores.Count == 0)
        {
            Console.WriteLine("Nenhum espectador cadastrado.");
            return;
        }
        for (int i = 0; i < espectadores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {espectadores[i].Nome} - {espectadores[i].TipoIngresso}");
        }
    }

    private void AtualizarEspectador()
    {
        if (espectadores.Count == 0)
        {
            Console.WriteLine("Nenhum espectador para atualizar.");
            return;
        }
        ListarEspectadores();
        int idx = LerInteiro("Selecione o espectador a atualizar: ") - 1;
        if (idx >= 0 && idx < espectadores.Count)
        {
            Espectadores espectador = espectadores[idx];
            string nome = LerString($"Novo nome ({espectador.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) espectador.Nome = nome;
            Console.WriteLine("Espectador atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarEspectador()
    {
        if (espectadores.Count == 0)
        {
            Console.WriteLine("Nenhum espectador para deletar.");
            return;
        }
        ListarEspectadores();
        int idx = LerInteiro("Selecione o espectador a deletar: ") - 1;
        if (idx >= 0 && idx < espectadores.Count)
        {
            espectadores.RemoveAt(idx);
            Console.WriteLine("Espectador deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarIngressos()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Ingressos ===");
            Console.WriteLine("1. Criar Ingresso");
            Console.WriteLine("2. Listar Ingressos");
            Console.WriteLine("3. Atualizar Ingresso");
            Console.WriteLine("4. Deletar Ingresso");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarIngresso(); break;
                case 2: ListarIngressos(); break;
                case 3: AtualizarIngresso(); break;
                case 4: DeletarIngresso(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarIngresso()
    {
        string tipo = LerString("Tipo (VIP/Normal/Estudante): ");
        double preco = LerDouble("Preço: ");
        int numero = LerInteiro("Número: ");
        string assento = LerString("Assento: ");

        ingressos.Add(new Ingressos(tipo, preco, numero, assento));
        Console.WriteLine("Ingresso criado com sucesso!");
    }

    private void ListarIngressos()
    {
        if (ingressos.Count == 0)
        {
            Console.WriteLine("Nenhum ingresso cadastrado.");
            return;
        }
        for (int i = 0; i < ingressos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ingressos[i].Tipo} - {ingressos[i].Assento}");
        }
    }

    private void AtualizarIngresso()
    {
        if (ingressos.Count == 0)
        {
            Console.WriteLine("Nenhum ingresso para atualizar.");
            return;
        }
        ListarIngressos();
        int idx = LerInteiro("Selecione o ingresso a atualizar: ") - 1;
        if (idx >= 0 && idx < ingressos.Count)
        {
            Ingressos ingresso = ingressos[idx];
            string tipo = LerString($"Novo tipo ({ingresso.Tipo}): ");
            if (!string.IsNullOrEmpty(tipo)) ingresso.Tipo = tipo;
            Console.WriteLine("Ingresso atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarIngresso()
    {
        if (ingressos.Count == 0)
        {
            Console.WriteLine("Nenhum ingresso para deletar.");
            return;
        }
        ListarIngressos();
        int idx = LerInteiro("Selecione o ingresso a deletar: ") - 1;
        if (idx >= 0 && idx < ingressos.Count)
        {
            ingressos.RemoveAt(idx);
            Console.WriteLine("Ingresso deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarInstrumentos()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Instrumentos ===");
            Console.WriteLine("1. Criar Instrumento");
            Console.WriteLine("2. Listar Instrumentos");
            Console.WriteLine("3. Atualizar Instrumento");
            Console.WriteLine("4. Deletar Instrumento");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarInstrumento(); break;
                case 2: ListarInstrumentos(); break;
                case 3: AtualizarInstrumento(); break;
                case 4: DeletarInstrumento(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarInstrumento()
    {
        string nome = LerString("Nome: ");
        string tipo = LerString("Tipo: ");
        string fabricante = LerString("Fabricante: ");
        int ano = LerInteiro("Ano fabricação: ");
        string material = LerString("Material: ");
        double preco = LerDouble("Preço: ");

        instrumentos.Add(new Instrumento(nome, tipo, fabricante, ano, material, preco));
        Console.WriteLine("Instrumento criado com sucesso!");
    }

    private void ListarInstrumentos()
    {
        if (instrumentos.Count == 0)
        {
            Console.WriteLine("Nenhum instrumento cadastrado.");
            return;
        }
        for (int i = 0; i < instrumentos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {instrumentos[i].Nome} - {instrumentos[i].Tipo}");
        }
    }

    private void AtualizarInstrumento()
    {
        if (instrumentos.Count == 0)
        {
            Console.WriteLine("Nenhum instrumento para atualizar.");
            return;
        }
        ListarInstrumentos();
        int idx = LerInteiro("Selecione o instrumento a atualizar: ") - 1;
        if (idx >= 0 && idx < instrumentos.Count)
        {
            Instrumento instrumento = instrumentos[idx];
            string nome = LerString($"Novo nome ({instrumento.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) instrumento.Nome = nome;
            Console.WriteLine("Instrumento atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarInstrumento()
    {
        if (instrumentos.Count == 0)
        {
            Console.WriteLine("Nenhum instrumento para deletar.");
            return;
        }
        ListarInstrumentos();
        int idx = LerInteiro("Selecione o instrumento a deletar: ") - 1;
        if (idx >= 0 && idx < instrumentos.Count)
        {
            instrumentos.RemoveAt(idx);
            Console.WriteLine("Instrumento deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarLocais()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Locais de Apresentação ===");
            Console.WriteLine("1. Criar Local");
            Console.WriteLine("2. Listar Locais");
            Console.WriteLine("3. Atualizar Local");
            Console.WriteLine("4. Deletar Local");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarLocal(); break;
                case 2: ListarLocais(); break;
                case 3: AtualizarLocal(); break;
                case 4: DeletarLocal(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarLocal()
    {
        string nome = LerString("Nome: ");
        int capacidade = LerInteiro("Capacidade: ");
        string cidade = LerString("Cidade: ");
        string endereco = LerString("Endereço: ");
        string tipo = LerString("Tipo: ");
        int ano = LerInteiro("Ano inauguração: ");

        locais.Add(new LocalApresentacao(nome, capacidade, cidade, endereco, tipo, ano));
        Console.WriteLine("Local criado com sucesso!");
    }

    private void ListarLocais()
    {
        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum local cadastrado.");
            return;
        }
        for (int i = 0; i < locais.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {locais[i].Nome} - {locais[i].Capacidade} lugares");
        }
    }

    private void AtualizarLocal()
    {
        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum local para atualizar.");
            return;
        }
        ListarLocais();
        int idx = LerInteiro("Selecione o local a atualizar: ") - 1;
        if (idx >= 0 && idx < locais.Count)
        {
            LocalApresentacao local = locais[idx];
            string nome = LerString($"Novo nome ({local.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) local.Nome = nome;
            Console.WriteLine("Local atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarLocal()
    {
        if (locais.Count == 0)
        {
            Console.WriteLine("Nenhum local para deletar.");
            return;
        }
        ListarLocais();
        int idx = LerInteiro("Selecione o local a deletar: ") - 1;
        if (idx >= 0 && idx < locais.Count)
        {
            locais.RemoveAt(idx);
            Console.WriteLine("Local deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarMaestros()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Maestros ===");
            Console.WriteLine("1. Criar Maestro");
            Console.WriteLine("2. Listar Maestros");
            Console.WriteLine("3. Atualizar Maestro");
            Console.WriteLine("4. Deletar Maestro");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarMaestro(); break;
                case 2: ListarMaestros(); break;
                case 3: AtualizarMaestro(); break;
                case 4: DeletarMaestro(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarMaestro()
    {
        string nome = LerString("Nome: ");
        int idade = LerInteiro("Idade: ");
        string especialidade = LerString("Especialidade: ");
        int experiencia = LerInteiro("Anos experiência: ");
        double salario = LerDouble("Salário: ");
        string nacionalidade = LerString("Nacionalidade: ");

        maestros.Add(new Maestro(nome, idade, especialidade, experiencia, salario, nacionalidade));
        Console.WriteLine("Maestro criado com sucesso!");
    }

    private void ListarMaestros()
    {
        if (maestros.Count == 0)
        {
            Console.WriteLine("Nenhum maestro cadastrado.");
            return;
        }
        for (int i = 0; i < maestros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {maestros[i].Nome} - {maestros[i].Especialidade}");
        }
    }

    private void AtualizarMaestro()
    {
        if (maestros.Count == 0)
        {
            Console.WriteLine("Nenhum maestro para atualizar.");
            return;
        }
        ListarMaestros();
        int idx = LerInteiro("Selecione o maestro a atualizar: ") - 1;
        if (idx >= 0 && idx < maestros.Count)
        {
            Maestro maestro = maestros[idx];
            string nome = LerString($"Novo nome ({maestro.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) maestro.Nome = nome;
            Console.WriteLine("Maestro atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarMaestro()
    {
        if (maestros.Count == 0)
        {
            Console.WriteLine("Nenhum maestro para deletar.");
            return;
        }
        ListarMaestros();
        int idx = LerInteiro("Selecione o maestro a deletar: ") - 1;
        if (idx >= 0 && idx < maestros.Count)
        {
            maestros.RemoveAt(idx);
            Console.WriteLine("Maestro deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarMusicas()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Músicas ===");
            Console.WriteLine("1. Criar Música");
            Console.WriteLine("2. Listar Músicas");
            Console.WriteLine("3. Atualizar Música");
            Console.WriteLine("4. Deletar Música");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarMusica(); break;
                case 2: ListarMusicas(); break;
                case 3: AtualizarMusica(); break;
                case 4: DeletarMusica(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarMusica()
    {
        string nome = LerString("Nome: ");
        string compositor = LerString("Compositor: ");
        TimeSpan duracao = LerTimeSpan("Duração (hh:mm): ");
        int ano = LerInteiro("Ano composição: ");
        string genero = LerString("Gênero: ");
        string instrumentos = LerString("Instrumentos: ");

        musicas.Add(new Musicas(nome, compositor, duracao, ano, genero, instrumentos));
        Console.WriteLine("Música criada com sucesso!");
    }

    private void ListarMusicas()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("Nenhuma música cadastrada.");
            return;
        }
        for (int i = 0; i < musicas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {musicas[i].Nome} - {musicas[i].Compositor}");
        }
    }

    private void AtualizarMusica()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("Nenhuma música para atualizar.");
            return;
        }
        ListarMusicas();
        int idx = LerInteiro("Selecione a música a atualizar: ") - 1;
        if (idx >= 0 && idx < musicas.Count)
        {
            Musicas musica = musicas[idx];
            string nome = LerString($"Novo nome ({musica.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) musica.Nome = nome;
            Console.WriteLine("Música atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarMusica()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("Nenhuma música para deletar.");
            return;
        }
        ListarMusicas();
        int idx = LerInteiro("Selecione a música a deletar: ") - 1;
        if (idx >= 0 && idx < musicas.Count)
        {
            musicas.RemoveAt(idx);
            Console.WriteLine("Música deletada com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void GerenciarMusicos()
    {
        while (true)
        {
            Console.WriteLine("\n=== Gerenciar Músicos ===");
            Console.WriteLine("1. Criar Músico");
            Console.WriteLine("2. Listar Músicos");
            Console.WriteLine("3. Atualizar Músico");
            Console.WriteLine("4. Deletar Músico");
            Console.WriteLine("5. Voltar");
            int opcao = LerInteiro("Escolha uma opção: ");
            switch (opcao)
            {
                case 1: CriarMusico(); break;
                case 2: ListarMusicos(); break;
                case 3: AtualizarMusico(); break;
                case 4: DeletarMusico(); break;
                case 5: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    private void CriarMusico()
    {
        string nome = LerString("Nome: ");
        int idade = LerInteiro("Idade: ");
        string instrumento = LerString("Instrumento: ");
        int experiencia = LerInteiro("Experiência (anos): ");
        double salario = LerDouble("Salário: ");
        string tipo = LerString("Tipo (Solista/Sectionista): ");

        musicos.Add(new Musico(nome, idade, instrumento, experiencia, salario, tipo));
        Console.WriteLine("Músico criado com sucesso!");
    }

    private void ListarMusicos()
    {
        if (musicos.Count == 0)
        {
            Console.WriteLine("Nenhum músico cadastrado.");
            return;
        }
        for (int i = 0; i < musicos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {musicos[i].Nome} - {musicos[i].Instrumento}");
        }
    }

    private void AtualizarMusico()
    {
        if (musicos.Count == 0)
        {
            Console.WriteLine("Nenhum músico para atualizar.");
            return;
        }
        ListarMusicos();
        int idx = LerInteiro("Selecione o músico a atualizar: ") - 1;
        if (idx >= 0 && idx < musicos.Count)
        {
            Musico musico = musicos[idx];
            string nome = LerString($"Novo nome ({musico.Nome}): ");
            if (!string.IsNullOrEmpty(nome)) musico.Nome = nome;
            Console.WriteLine("Músico atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    private void DeletarMusico()
    {
        if (musicos.Count == 0)
        {
            Console.WriteLine("Nenhum músico para deletar.");
            return;
        }
        ListarMusicos();
        int idx = LerInteiro("Selecione o músico a deletar: ") - 1;
        if (idx >= 0 && idx < musicos.Count)
        {
            musicos.RemoveAt(idx);
            Console.WriteLine("Músico deletado com sucesso!");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
░██████╗██╗░░░██╗███╗░░██╗███████╗░█████╗░███╗░░██╗
██╔════╝╚██╗░██╔╝████╗░██║██╔════╝██╔══██╗████╗░██║
╚█████╗░░╚████╔╝░██╔██╗██║█████╗░░██║░░██║██╔██╗██║
░╚═══██╗░░╚██╔╝░░██║╚████║██╔══╝░░██║░░██║██║╚████║
██████╔╝░░░██║░░░██║░╚███║██║░░░░░╚█████╔╝██║░╚███║
╚═════╝░░░░╚═╝░░░╚═╝░░╚══╝╚═╝░░░░░░╚════╝░╚═╝░░╚══╝");
        Console.WriteLine(@"
█▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █▀█ █▀█ █▀█ █░█ █▀▀ █▀ ▀█▀ █▀█ ▄▀█
▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █▄█ █▀▄ ▀▀█ █▄█ ██▄ ▄█ ░█░ █▀▄ █▀█");
        Console.WriteLine(@"
█▀ █ █▄░█ █▀▀ █▀█ █▄░█ █ █▀▀ ▄▀█
▄█ █ █░▀█ █▀░ █▄█ █░▀█ █ █▄▄ █▀█");
        GerenciadorOrquestra gerenciador = new GerenciadorOrquestra();
        gerenciador.Iniciar();
    }
}