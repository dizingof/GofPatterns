Forest forest = new Forest();

// Посадимо кілька дерев у лісі
forest.PlantTree(10, 20, "Oak", "Green", "Rough");
forest.PlantTree(15, 25, "Pine", "Dark Green", "Smooth");
forest.PlantTree(10, 20, "Oak", "Green", "Rough"); // Легковес повторно використовує тип "Oak"

// Відобразимо всі дерева
forest.Draw();

Console.ReadKey();