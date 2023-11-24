# Money Tracking Application

## Overview
This money tracking application allows users to manage their expenses and incomes in a simple and intuitive way. Users can enter, edit, and remove items, assign them to a specific month, and save the current state to a file for later retrieval.

## Features
- **Modeling Items:**
  - Each item is represented with a title, amount, and assigned month.
  - Distinguishes between income and expense items.
  - 
- **Adding Items:**
  - User can Add new Items.
  - Add selection  between income and expense items.
- **Display and Sorting:**
  - Collection of items can be displayed and sorted in ascending or descending order.
  - Sorting options include by month, amount, or title.

- **Filtering:**
  - Users can choose to display only expenses or only incomes.

- **Editing and Removing:**
  - Supports the ability to edit and remove items easily.

- **User Interface:**
  - Provides a text-based user interface accessible via the command-line.

- **Persistence:**
  - Allows users to save the current task list to a file.
  - Restores the former state when restarting the application.
  ## Customizing File Path

The application allows users to customize the file path for loading and saving items. By default, the file path is set to a specific location, but you can easily change it to fit your preferences.

### Changing File Path

1. Open the `MoneyItemsManager` class in th project.
2. Locate the variable or property that specifies the file path for loading and saving items.
3. Modify the file path to your desired location.
