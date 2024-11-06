using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelpercsv = new();
exportHelpercsv.ExportStudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");