ReservaRegular reserva1 = new ReservaRegular("Fernando de Noronha", true);
reserva1.Verificacao();
reserva1.Reserva();
reserva1.Cancelar();
reserva1.Status();
Console.WriteLine();

ReservaUP reserva2 = new ReservaUP("Natal", true);
reserva2.Verificacao();
reserva2.Reserva();
reserva2.Cancelar();
reserva2.Status();
Console.WriteLine();

GruposGrandes reserva3 = new GruposGrandes("Grecia", true);
reserva3.Verificacao();
reserva3.Reserva();
reserva3.Cancelar();
reserva3.Status();
Console.WriteLine();