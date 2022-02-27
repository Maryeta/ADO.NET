Используется Entity Framework.
Подход Database first.

Подключение к БД Northwind.
На базе таблиц Categories, Products, Suppliers с помощью мастера формируется EDM.


В ЭУ DataGridView отображаются Products по выбранной категории (ComboBox "Category").

Добавить новый продукт можно заполнив текстовые поля в GroupBox "New Product", выбрав Supplier из списка и нажав кнопку "Add".
При добавлении присваиваются SupplierID и CategoryID, исходя из выбранных Categoty и Supplier в соответствующих полях.

Кнопка "Save" сохраняет внесённые изменения, путем вызова метода SaveChanges().

Кнопка "Delete" удаляет Product. Через выделенную строку получаем объект Product и помечаем его как Deleted. Далее SaveChanges().



 
