# Task: E-commerce Order Synchronization System
## Backstory of the Task
As the head of an e-commerce company, I want to synchronize daily data from warehouses and partner stores into a centralized order management system (OMS). Each partner operates locally, tracking orders, returns, and inventory on a local database. Internet connectivity issues prevent real-time synchronization, so partners send daily transaction files to a central location.

## Current Challenges:
Partners operate in remote locations with limited or no reliable internet.
Transactional data (e.g., orders, returns, inventory updates) is tracked locally and sent to the central OMS at the end of the day.
Files are not always uniform in format, requiring robust validation and error handling.
Dependencies exist between the files, such as inventory availability before processing orders or validating returns.

## Objective:
Build a system that:

1. Processes daily files (CSV, Text, JSON, XML, Excel) received from partners and warehouses.
2. Validates the data for integrity and applies business rules.
3. Populates the centralized database with validated data.
4. Logs the status of each file, number of records processed, and any errors encountered.


# Workflow Overview:
## File Processing Workflow

1. Monitor the root folder (D:/EcommerceData/) for subfolders representing partner codes (e.g., WHHYD001, PRTBLR002).
2. Check for new files in each folder every hour.
3. Process each file type, validate the data, and load it into the central OMS database.

## After processing:
1. Move successfully processed files to the Processed folder.
2. Archive files for historical reference in the Archive folder.
3. Move files with errors to the Error folder for debugging.

## File Types:
Files are provided in the following formats:

1. Orders: Orders_yyyyMMdd.csv (Comma-delimited)
2. Returns: Returns_yyyyMMdd.xml
3. Inventory Updates: Inventory_yyyyMMdd.json
4. Partner Information: Partners_yyyyMMdd.txt (Pipe-delimited)
5. Product Details: ProductDetails_yyyyMMdd.xlsx with multiple sheets:
	- Sheet1: Products
	- Sheet2: ProductCategories
	
### File Details
#### 1. Orders (Orders.csv)
#### Format: Comma-delimited
#### Sample Data:

    OrderID,PartnerCode,CustomerID,ProductID,OrderDate,Quantity,TotalAmount
    101,WHHYD001,CUST001,PRD001,2023-11-21,2,500.00
    102,PRTBLR002,CUST002,PRD002,2023-11-21,1,300.00
	
#### 2. Returns (Returns.xml)
#### Format: XML
#### Sample Data:


`<Returns>
  <Return>
    <ReturnID>R001</ReturnID>
    <OrderID>101</OrderID>
    <ReturnDate>2023-11-22</ReturnDate>
    <Reason>Defective</Reason>
    <AmountRefunded>500.00</AmountRefunded>
  </Return>
</Returns>`

#### 3. Inventory Updates (Inventory.json)
#### Format: JSON
#### Sample Data:

`[
  {
    "ProductID": "PRD001",
    "PartnerCode": "WHHYD001",
    "StockDate": "2023-11-21",
    "QuantityAvailable": 100,
    "PricePerUnit": 250.00
  },
  {
    "ProductID": "PRD002",
    "PartnerCode": "PRTBLR002",
    "StockDate": "2023-11-21",
    "QuantityAvailable": 50,
    "PricePerUnit": 300.00
  }
]`

#### 4. Partner Information (Partners.txt)
#### Format: Pipe-delimited
#### Sample Data:

    PartnerCode|PartnerName|Location|ContactNumber
    WHHYD001|Hyderabad Warehouse|Hyderabad|9876543210
    PRTBLR002|Bangalore Partner|Bangalore|9876543211

#### 5. Product Details (ProductDetails.xlsx)
#### Sheet1: Products

|ProductID	|ProductName|	CategoryID|	PricePerUnit	|QuantityAvailable|
|---------|---------|------------|-------------|-----------|
|PRD001|	Soap|	1|	50.00|	100|
|PRD002	|Shampoo	|2|	150.00|	50|

Sheet2: ProductCategories

|CategoryID	|CategoryName	|
|------------|-------|
|1			|Personal Care  |
|2			|Hair Care      |
# Database Schema

## 1. Partners Table
| Column Name   | Data Type      | Constraints            |
|---------------|----------------|------------------------|
| PartnerID     | INT            | Primary Key            |
| PartnerCode   | VARCHAR(50)    | NOT NULL, UNIQUE       |
| PartnerName   | VARCHAR(100)   | NOT NULL               |
| Location      | VARCHAR(50)    |                        |
| ContactNumber | VARCHAR(15)    |                        |

---

## 2. Products Table
| Column Name        | Data Type      | Constraints          |
|---------------------|----------------|----------------------|
| ProductID          | INT            | Primary Key          |
| ProductName        | VARCHAR(100)   | NOT NULL             |
| CategoryID         | INT            | Foreign Key          |
| PricePerUnit       | DECIMAL(10, 2) |                      |
| QuantityAvailable  | INT            |                      |

---

## 3. ProductCategories Table
| Column Name  | Data Type      | Constraints       |
|--------------|----------------|-------------------|
| CategoryID   | INT            | Primary Key       |
| CategoryName | VARCHAR(100)   | NOT NULL          |

---

## 4. Orders Table
| Column Name      | Data Type      | Constraints             |
|-------------------|----------------|-------------------------|
| OrderID          | INT            | Primary Key             |
| PartnerID        | INT            | Foreign Key (Partners)  |
| CustomerID       | VARCHAR(50)    |                         |
| ProductID        | INT            | Foreign Key (Products)  |
| OrderDate        | DATE           |                         |
| Quantity         | INT            |                         |
| TotalAmount      | DECIMAL(10, 2) |                         |

---

## 5. Returns Table
| Column Name      | Data Type      | Constraints             |
|-------------------|----------------|-------------------------|
| ReturnID         | INT            | Primary Key             |
| OrderID          | INT            | Foreign Key (Orders)    |
| ReturnDate       | DATE           |                         |
| Reason           | VARCHAR(100)   |                         |
| AmountRefunded   | DECIMAL(10, 2) |                         |

## Business Rules
### Validation:

1. Ensure PartnerCode exists in the Partners table.
2. Validate sufficient inventory before processing orders.
3. Orders cannot have OrderDate in the future.
4. Returns must reference a valid OrderID and cannot exceed the original order amount.

### Relationships:
Maintain proper relationships between orders, returns, and inventory.

### Error Handling:
Skip invalid rows, log errors, and continue processing valid data.
Logging Requirements

### Log File Format:
Log all activities in D:/Logs/EcommerceDataLog.txt.

### Sample log entries:
[Timestamp] INFO: Successfully processed PartnerCode: WHHYD001. Files: 4, Records: 150
[Timestamp] ERROR: Insufficient stock for OrderID: 102, ProductID: PRD002.

### Log Success and Failure Counts:
Include total files processed, records inserted, skipped, and errors for each partner.

## Folder Structure
### Root Folder: D:/EcommerceData/
### Subfolders: D:/EcommerceData/WHHYD001/
New: Files to be processed.
Processed: Successfully processed files.
Archive: Historical files for backup.
Error: Files with errors.

### Expected Learning Outcomes
1. Working with various file formats (CSV, JSON, XML, Excel).
2. Implementing folder monitoring with file operations.
3. Handling relationships in relational databases.
4. Building robust error handling and logging systems.
