using New_POS_Application.Properties;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace New_POS_Application
{
    // Define a MenuItem class (using fields)
    public class MenuItem
    {
        //global variables
        public string Name, Price, ImagePath;



        public MenuItem(string name, string price, string imagePath)
        {
            this.Name = name;
            this.Price = price;
            this.ImagePath = imagePath;

        }
    }

    // Static class that holds the list of MenuItems
    public static class MenuData
    {
        // You can change the file extensions as needed (jfif, jpg, etc.)
        public static List<MenuItem> BreakfastItem = new List<MenuItem>
        {
            new MenuItem("Pancakes", "100", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b1.jfif"),
            new MenuItem("Scrambled Eggs", "120", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b2.jfif"),
            new MenuItem("French Toast", "130", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b3.jfif"),
            new MenuItem("Sunny Side Up", "132", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b4.jfif"),
            new MenuItem("Egg Sandwich", "140", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b5.jfif"),
            new MenuItem("Bacon and Eggs", "150", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b6.jfif"),
            new MenuItem("Fruit Salad", "110", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b7.jfif"),
            new MenuItem("Avocado Toast", "145", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b8.jfif"),
            new MenuItem("Bagel with Cream Cheese", "180", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b9.jfif"),
            new MenuItem("Omelette", "160", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b10.jfif"),
            new MenuItem("Vegetable Frittata", "95", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b11.jfif"),
            new MenuItem("Porridge", "125", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b12.jfif"),
            new MenuItem("Smoothie Bowl", "175", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b13.jfif"),
            new MenuItem("Breakfast Burrito", "155", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b14.jfif"),
            new MenuItem("Granola with Yogurt", "170", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b15.jfif"),
            new MenuItem("Croissant", "210", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b16.jfif"),
            new MenuItem("Chia Pudding", "120", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b17.jfif"),
            new MenuItem("Cereal with Milk", "100", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b18.jfif"),
            new MenuItem("Breakfast Quiche", "115", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b19.jfif"),
            new MenuItem("Shakshuka", "195", @"C:\\Users\\Kaiser\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\breakfast\\b20.jfif"),


        };


        public static List<MenuItem> DinnerItems = new List<MenuItem>
        {
            new MenuItem("Steak", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d1.jfif"),
            new MenuItem("Salmon Teriyaki", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d2.jfif"),
            new MenuItem("Grilled Chicken", "150", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d3.jfif"),
            new MenuItem("Pasta Alfredo", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d4.jfif"),
            new MenuItem("Beef Burger", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d5.jfif"),
            new MenuItem("Fish and Chips", "140", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d6.jfif"),
            new MenuItem("Shrimp Tempura", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d7.jfif"),
            new MenuItem("Sushi Platter", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d8.jfif"),
            new MenuItem("Ramen Bowl", "175", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d9.jfif"),
            new MenuItem("Caesar Salad", "130", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d10.jfif"),
            new MenuItem("Lamb Chops", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d11.jfif"),
            new MenuItem("BBQ Ribs", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d12.jfif"),
            new MenuItem("Grilled Salmon", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d13.jfif"),
            new MenuItem("Tuna Steak", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d14.jfif"),
            new MenuItem("Pizza Margherita", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d15.jfif"),
            new MenuItem("Cheese Quesadilla", "145", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d16.jfif"),
            new MenuItem("Pork Adobo", "185", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d17.jfif"),
            new MenuItem("Vegetable Stir Fry", "140", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d18.jfif"),
            new MenuItem("Chicken Curry", "175", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d19.jfif"),
            new MenuItem("Mushroom Risotto", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dinner\\d20.jfif"),

        };
        public static List<MenuItem> LunchItems = new List<MenuItem>
        {
            new MenuItem("Grilled Chicken", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l1.jfif"),
            new MenuItem("Caesar Salad", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l2.jfif"),
            new MenuItem("Beef Burger", "300", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l3.jfif"),
            new MenuItem("Vegetarian Wrap", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l4.jfif"),
            new MenuItem("Grilled Salmon", "350", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l5.jfif"),
            new MenuItem("Chicken Tenders", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l6.jfif"),
            new MenuItem("BBQ Ribs", "400", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l7.jfif"),
            new MenuItem("Spaghetti Bolognese", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l8.jfif"),
            new MenuItem("Pulled Pork Sandwich", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l9.jfif"),
            new MenuItem("Chicken Alfredo", "280", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l10.jfif"),
            new MenuItem("Falafel Plate", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l11.jfif"),
            new MenuItem("Pork Schnitzel", "350", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l12.jfif"),
            new MenuItem("Chicken Shawarma", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l13.jfif"),
            new MenuItem("Steak Frites", "400", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l14.jfif"),
            new MenuItem("Lamb Chops", "450", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l15.jfif"),
            new MenuItem("Fish and Chips", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l16.jfif"),
            new MenuItem("Pasta Primavera", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l17.jfif"),
            new MenuItem("Turkey Club Sandwich", "240", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l18.jfif"),
            new MenuItem("Grilled Shrimp Skewers", "300", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l19.jfif"),
            new MenuItem("Chicken Caesar Wrap", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\lunch\\l20.jfif"),

        };
        public static List<MenuItem> BeverageItems = new List<MenuItem>
        {
            new MenuItem("Beer - Lager", "150", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\beer1.jfif"),
            new MenuItem("Beer - IPA", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\beer2.jfif"),
            new MenuItem("Beer - Stout", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\beer3.jfif"),
            new MenuItem("Beer - Pilsner", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\beer4.jfif"),
            new MenuItem("Beer - Wheat", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\beer5.jfif"),
            new MenuItem("Beer - Pale Ale", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\juice1.jfif"),
            new MenuItem("Soda - Cola", "80", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\juice2.jfif"),
            new MenuItem("Soda - Lemonade", "90", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\juice3.jfif"),
            new MenuItem("Soda - Orange", "85", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\juice4.jfif"),
            new MenuItem("Soda - Root Beer", "95", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\juice5.jfif"),
            new MenuItem("Tea - Green", "100", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\soda1.jfif"),
            new MenuItem("Tea - Black", "110", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\soda2.jfif"),
            new MenuItem("Tea - Herbal", "120", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\soda3.jfif"),
            new MenuItem("Tea - Chai", "130", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\soda4.jfif"),
            new MenuItem("Tea - Oolong", "140", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea1.jfif"),
            new MenuItem("Tea - Jasmine", "150", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea2.jfif"),
            new MenuItem("Tea - Earl Grey", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea3.jfif"),
            new MenuItem("Juice - Orange", "120", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea7.jfif"),
            new MenuItem("Juice - Apple", "130", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea5.jfif"),
            new MenuItem("Juice - Grape", "140", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\beverages\\tea6.jfif"),

        };
        public static List<MenuItem> DessertItem = new List<MenuItem>
        {
            new MenuItem("Chocolate Cake", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s1.jfif"),
            new MenuItem("Strawberry Cheesecake", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s2.jfif"),
            new MenuItem("Vanilla Pudding", "150", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s3.jfif"),
            new MenuItem("Tiramisu", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s4.jfif"),
            new MenuItem("Lemon Meringue Pie", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s5.jfif"),
            new MenuItem("Apple Crumble", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s6.jfif"),
            new MenuItem("Carrot Cake", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s7.jfif"),
            new MenuItem("Peach Cobbler", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s8.jfif"),
            new MenuItem("Chocolate Mousse", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s9.jfif"),
            new MenuItem("Raspberry Sorbet", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s10.jfif"),
            new MenuItem("Cinnamon Rolls", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s11.jfif"),
            new MenuItem("Banoffee Pie", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s12.jfif"),
            new MenuItem("Molten Lava Cake", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s13.jfif"),
            new MenuItem("Pavlova", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s14.jfif"),
            new MenuItem("Blueberry Muffin", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s15.jfif"),
            new MenuItem("Churros", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s16.jfif"),
            new MenuItem("Coconut Cream Pie", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s17.jfif"),
            new MenuItem("S'mores", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s18.jfif"),
            new MenuItem("Nutella Crepes", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s19.jfif"),
            new MenuItem("Raisin Bread Pudding", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\dessert\\s20.jfif")


        };
        public static List<MenuItem> CoffeeItems = new List<MenuItem>
        {

            new MenuItem("Espresso", "150", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c1.jfif"),
            new MenuItem("Cappuccino", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c2.jfif"),
            new MenuItem("Latte", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c3.jfif"),
            new MenuItem("Americano", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c4.jfif"),
            new MenuItem("Mocha", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c5.jfif"),
            new MenuItem("Macchiato", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c6.jfif"),
            new MenuItem("Flat White", "170", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c7.jfif"),
            new MenuItem("Iced Coffee", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c8.jfif"),
            new MenuItem("Affogato", "200", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c9.jfif"),
            new MenuItem("Irish Coffee", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c10.jfif"),
            new MenuItem("Cortado", "175", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c11.jfif"),
            new MenuItem("Turkish Coffee", "160", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c12.jfif"),
            new MenuItem("Cold Brew", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c13.jfif"),
            new MenuItem("Nitro Coffee", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c14.jfif"),
            new MenuItem("Doppio", "140", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c15.jfif"),
            new MenuItem("Viennese Coffee", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c16.jfif"),
            new MenuItem("Caramel Latte", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c17.jfif"),
            new MenuItem("Pumpkin Spice Latte", "190", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c18.jfif"),
            new MenuItem("Hazelnut Coffee", "175", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c19.jfif"),
            new MenuItem("Coconut Coffee", "180", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\coffee\\c20.jfif")


        };
        public static List<MenuItem> PizzaItems = new List<MenuItem>
        {
            new MenuItem("Pizza Margherita", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p1.jfif"),
            new MenuItem("Pepperoni Pizza", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p2.jfif"),
            new MenuItem("Veggie Pizza", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p3.jfif"),
            new MenuItem("BBQ Chicken Pizza", "270", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p4.jfif"),
            new MenuItem("Hawaiian Pizza", "240", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p5.jfif"),
            new MenuItem("Seafood Pizza", "280", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p6.jfif"),
            new MenuItem("Four Cheese Pizza", "260", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p7.jfif"),
            new MenuItem("Mushroom Pizza", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p8.jfif"),
            new MenuItem("Meat Lovers Pizza", "300", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p9.jfif"),
            new MenuItem("Cheese Stuffed Crust Pizza", "320", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p10.jfif"),
            new MenuItem("Margherita Pizza with Basil", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p11.jfif"),
            new MenuItem("Pepperoni & Mushroom Pizza", "270", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p12.jfif"),
            new MenuItem("Chicken Alfredo Pizza", "290", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p13.jfif"),
            new MenuItem("Spinach & Feta Pizza", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p14.jfif"),
            new MenuItem("Pesto Chicken Pizza", "280", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p15.jfif"),
            new MenuItem("Garlic & Herb Pizza", "220", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p16.jfif"),
            new MenuItem("Vegetarian Delight Pizza", "240", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p17.jfif"),
            new MenuItem("Caprese Pizza", "230", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p18.jfif"),
            new MenuItem("Tomato Basil Pizza", "210", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p19.jfif"),
            new MenuItem("Beef & Onion Pizza", "250", @"C:\\Users\\Kaiser\\Downloads\\New_POS_Application-20250220T063002Z-001\\New_POS_Application\\New_POS_Application\\Resources\\pizza\\p20.jfif")

        };

        // Optional method-based approach:
        public static List<MenuItem> GetBreakfastItems()
        {
            return BreakfastItem;
        }
        public static List<MenuItem> GetDinnerItems()
        {
            return DinnerItems;
        }
        public static List<MenuItem> GetLunchItems()
        {
            return LunchItems;
        }
        public static List<MenuItem> GetBeveragesItems()
        {
            return BeverageItems;
        }
        public static List<MenuItem> GetDessertItems()
        {
            return DessertItem;
        }
        public static List<MenuItem> GetCoffeeItems()
        {
            return CoffeeItems;
        }
        public static List<MenuItem> GetPizzaItems()
        {
            return PizzaItems;
        }
    }

}

