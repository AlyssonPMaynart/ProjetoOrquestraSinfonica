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
            Console.WriteLine("11. Sair");
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
                case 11: return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
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
        LocalApresentacao local = new LocalApresentacao("Local Padrão", 100, "Cidade", "Endereço", "Teatro", 2000);
        eventos.Add(new Evento(nome, tipo, data, hora, descricao, local));
        Console.WriteLine("Evento criado com sucesso!");
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
        LocalApresentacao local = new LocalApresentacao("Local Padrão", 100, "Cidade", "Endereço", "Teatro", 2000);
        string repertorio = LerString("Repertório: ");
        string maestro = LerString("Maestro: ");
        int ingressosDisponiveis = LerInteiro("Ingressos Disponíveis: ");
        int espectadoresPresentes = LerInteiro("Espectadores Presentes: ");
        concertos.Add(new Concerto(data, duracao, local, repertorio, maestro, ingressosDisponiveis, espectadoresPresentes));
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
            Console.WriteLine("Cadastre locais primeiro!");
            return;
        }
        ListarLocais();
        int localIdx = LerInteiro("Selecione o local pelo número: ") - 1;

        ensaios.Add(new Ensaios(data, hora, duracao, locais[localIdx], repertorio, maestro));
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
        GerenciadorOrquestra gerenciador = new GerenciadorOrquestra();
        gerenciador.Iniciar();
    }
}