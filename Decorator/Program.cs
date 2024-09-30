// Простой кофе
ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} Стоимость: {coffee.GetCost():C}");

// Добавляем молоко
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} Стоимость: {coffee.GetCost():C}");

// Добавляем сахар
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} Стоимость: {coffee.GetCost():C}");