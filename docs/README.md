---
title: Home
meta:
  - name: description
    content: Page description
  - name: keywords
    content: js vuejs vuepress
---

# advanced-selenium-workshop

> Online workshop excercises for advanced Selenium and working with Sauce Labs.

<p align="center">
  <img src="./images/thumbnail-256x256.png" />
</p>

[[toc]]

##### Check out for more Markdown Extensions [here](https://vuepress.vuejs.org/guide/markdown.html#header-anchors)

## Article 1

"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

## Article 2

"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

## Components

Source at docs/.vuepress/components/

* <Demo/>
* <Button-Counter :start="0"/>


# Exercise 1: Locate Provided Elements
1.  Checkout branch `01_locate_elements `.
2. Navigate to **src > test > exercsies > Location**.
3. Visit [www.saucedemo.com](https://www.saucedemo.com) and use the developer tools to inspect the following elements:
    * Username Field
    * Password Field
    * Login Button
4. In the first `@Test` method called **`locateUsernameField()`**, paste the relevant values:
    ```csharp
    String className = "";
    String tagName = "";
    Integer tagIndex = ;
    ```
5. Repeat the previous step for the following `@Test` methods:
    * `locatePasswordField()`
    * `locateLogInButton()`
6. Save your changes and run the **Location** class. You should see the following output:

<p align="center">
  <img src="./images/locations-failed.png" />
</p>
    
7. The test failed because there is more than one **`input`** tag with the class name **`"log-input"`**. Navigate to the **`locatePasswordField()`** class method. Enter a valid CSS selector in the following:
    ```csharp
    String cssSelector = "";
    ```
    > Use a browser developer tool to grab the css selector, for example in Chrome go to **View > Developer > Developer Tools** and right-click the element, then choose **Copy > Copy selector**
    
8. Save your changes and run the **Location** class. You should see the following output:

<p align="center">
  <img src="./images/locations.png" />
</p>