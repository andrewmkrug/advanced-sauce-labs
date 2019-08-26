using System;
using System.Collections.Generic;
using System.Text;
using workshop.Data;

namespace workshop.Exercises
{
    class ProductExcercise
    {
        public String name;
        public String price;

        public ProductExcercise() {
            this.name = "Sauce Labs Backpack";
            this.price = "29.99";
        }

        public static ProductExcercise FleeceJacket() {
            ProductExcercise product = new ProductExcercise();
            product.name = "Sauce Labs Fleece Jacket";
            product.price = "49.99";

            return product;
        }
    }
}
