// Создание отдельных продуктов
IProduct phone = new Product("Смартфон", 300);
IProduct laptop = new Product("Ноутбук", 700);
IProduct tablet = new Product("Планшет", 200);

// Создание группы продуктов
ProductGroup electronics = new ProductGroup("Электроника");
electronics.AddProduct(phone);
electronics.AddProduct(laptop);
electronics.AddProduct(tablet);

// Показ информации и вычисление общей стоимости
electronics.DisplayInfo();
Console.WriteLine($"Общая стоимость: {electronics.GetPrice():C}");

// Создание еще одной группы
IProduct book = new Product("Книга", 30);
ProductGroup misc = new ProductGroup("Разное");
misc.AddProduct(book);

// Создание главной группы
ProductGroup allProducts = new ProductGroup("Все товары");
allProducts.AddProduct(electronics);
allProducts.AddProduct(misc);

// Показ информации и вычисление общей стоимости всех товаров
allProducts.DisplayInfo();
Console.WriteLine($"Общая стоимость всех товаров: {allProducts.GetPrice():C}");