﻿using NoPassword;
using System.Text;

Console.WriteLine("Hello, World!");

string pgp = "mDMEYo2KBhYJKwYBBAHaRw8BAQdA/yd3mvMm+rJHS5XfuucdGe8C+jWgx/0Oywa1pSIwY6u0L1ZpbmljaXVzIE1vcmdhZG8gPHZpbmljaXVzX2RvbmF0dG9Ab3V0bG9vay5jb20+iJMEExYKADsCGwMFCwkIBwICIgIGFQoJCAsCBBYCAwECHgcCF4AWIQSZ68K3jmoGi8u1jmUu1sypzaWQowUCYo2KngAKCRAu1sypzaWQo1ryAP9lidCfso0/CQDIwLtfmN/+IIBt/N9i4ceAX4RwLs4vFgD+L8qq+lUpGD5IdVqUVucM5A4JH9rtPz3S5Cf0KqiaQg64OARijYoGEgorBgEEAZdVAQUBAQdAEDdt546XLZUZ8hqETsTjsHSZfsJQ2VzaVrYLfwHFdiYDAQgHiHgEGBYKACACGwwWIQSZ68K3jmoGi8u1jmUu1sypzaWQowUCYo2KpwAKCRAu1sypzaWQo1GJAQCDF8GhmaE9+m9iQeBya/UMyB1Bp2/36JISCveYpo542AD/caXh8nSuYrYi4BsQO5uZ2YQS7cPnCN3gpkWKFIkG4Q4==Yk5k";
byte[] byteArray = Encoding.UTF8.GetBytes(pgp);
MemoryStream stream = new(byteArray);

MemoryStream token = EncryptionHelper.TokenGenerator();

EncryptionHelper.EncryptToken(stream, token);