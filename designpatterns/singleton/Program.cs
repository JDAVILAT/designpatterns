// See https://aka.ms/new-console-template for more information
using singleton;

Console.WriteLine("Hello, World!");

log log = log.Instance;

log.save("prueba 01");

log a = log.Instance;
log b = log.Instance;

Console.WriteLine(a == b);