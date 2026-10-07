-- ===================================================================
-- CƠ SỞ DỮ LIỆU: eShoppingDB (Microsoft SQL Server 2019 / 2022)
-- ===================================================================
CREATE DATABASE eShoppingDB;
GO
USE eShoppingDB;
GO

-- 1. BẢNG KHÁCH HÀNG (CUSTOMER)
CREATE TABLE CUSTOMER (
    customer_id VARCHAR(36) PRIMARY KEY,
    full_name NVARCHAR(150) NOT NULL,
    dob DATE NOT NULL,
    identity_no VARCHAR(25) NOT NULL UNIQUE, -- CMND / Passport
    address NVARCHAR(255) NOT NULL,
    phone VARCHAR(15) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    created_at DATETIME DEFAULT GETDATE()
);

-- 2. BẢNG TÀI KHOẢN (ACCOUNT)
CREATE TABLE ACCOUNT (
    account_id VARCHAR(36) PRIMARY KEY,
    customer_id VARCHAR(36) NOT NULL UNIQUE,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    created_date DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    CONSTRAINT FK_Account_Customer FOREIGN KEY (customer_id) 
        REFERENCES CUSTOMER(customer_id) ON DELETE CASCADE
);

-- 3. BẢNG NHÓM SẢN PHẨM (PRODUCT_CATEGORY)
CREATE TABLE PRODUCT_CATEGORY (
    category_id VARCHAR(30) PRIMARY KEY,
    category_name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255) NULL
);

-- 4. BẢNG SẢN PHẨM (PRODUCT)
CREATE TABLE PRODUCT (
    product_id VARCHAR(50) PRIMARY KEY,
    category_id VARCHAR(30) NOT NULL,
    product_name NVARCHAR(200) NOT NULL,
    manufacturer NVARCHAR(100) NOT NULL,
    image_urls NVARCHAR(MAX) NULL,
    description NVARCHAR(MAX) NULL,
    technical_specs NVARCHAR(MAX) NULL,
    current_price DECIMAL(15, 2) NOT NULL CHECK (current_price >= 0),
    in_stock BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Product_Category FOREIGN KEY (category_id) 
        REFERENCES PRODUCT_CATEGORY(category_id)
);

-- 5. BẢNG LOẠI PHIẾU ĐẶT HÀNG (DELIVERY_METHOD)
CREATE TABLE DELIVERY_METHOD (
    method_id VARCHAR(20) PRIMARY KEY, -- STANDARD, EXPRESS, SAME_DAY
    method_name NVARCHAR(100) NOT NULL,
    estimated_hours INT NOT NULL,
    description NVARCHAR(255) NULL
);

-- 6. BẢNG CƯỚC GIAO HÀNG KHU VỰC (SHIPPING_RATE)
CREATE TABLE SHIPPING_RATE (
    rate_id INT IDENTITY(1,1) PRIMARY KEY,
    method_id VARCHAR(20) NOT NULL,
    region_name NVARCHAR(100) NOT NULL,
    base_fee DECIMAL(15, 2) NOT NULL CHECK (base_fee >= 0),
    CONSTRAINT FK_Rate_Method FOREIGN KEY (method_id) 
        REFERENCES DELIVERY_METHOD(method_id)
);

-- 7. BẢNG ĐƠN ĐẶT HÀNG (ORDERS)
CREATE TABLE ORDERS (
    order_id VARCHAR(36) PRIMARY KEY,
    customer_id VARCHAR(36) NOT NULL,
    method_id VARCHAR(20) NOT NULL,
    order_date DATETIME NOT NULL DEFAULT GETDATE(),
    recipient_name NVARCHAR(150) NOT NULL,
    recipient_address NVARCHAR(255) NOT NULL,
    recipient_phone VARCHAR(15) NOT NULL,
    sub_total DECIMAL(15, 2) NOT NULL CHECK (sub_total >= 0),
    shipping_fee DECIMAL(15, 2) NOT NULL DEFAULT 0 CHECK (shipping_fee >= 0),
    payment_fee DECIMAL(15, 2) NOT NULL DEFAULT 0 CHECK (payment_fee >= 0),
    total_amount DECIMAL(15, 2) NOT NULL CHECK (total_amount >= 0),
    order_status VARCHAR(30) NOT NULL DEFAULT 'PAID'
        CHECK (order_status IN ('PENDING', 'PAID', 'SHIPPING', 'COMPLETED', 'CANCELLED')),
    CONSTRAINT FK_Order_Customer FOREIGN KEY (customer_id) REFERENCES CUSTOMER(customer_id),
    CONSTRAINT FK_Order_DeliveryMethod FOREIGN KEY (method_id) REFERENCES DELIVERY_METHOD(method_id)
);

-- 8. BẢNG CHI TIẾT ĐƠN ĐẶT HÀNG (ORDER_DETAIL)
CREATE TABLE ORDER_DETAIL (
    order_id VARCHAR(36) NOT NULL,
    product_id VARCHAR(50) NOT NULL,
    quantity INT NOT NULL CHECK (quantity > 0),
    unit_price DECIMAL(15, 2) NOT NULL CHECK (unit_price >= 0),
    PRIMARY KEY (order_id, product_id),
    CONSTRAINT FK_Detail_Order FOREIGN KEY (order_id) REFERENCES ORDERS(order_id) ON DELETE CASCADE,
    CONSTRAINT FK_Detail_Product FOREIGN KEY (product_id) REFERENCES PRODUCT(product_id)
);

-- 9. BẢNG GIAO DỊCH THANH TOÁN THẺ (PAYMENT_TRANSACTION)
CREATE TABLE PAYMENT_TRANSACTION (
    transaction_id VARCHAR(36) PRIMARY KEY,
    order_id VARCHAR(36) NOT NULL UNIQUE,
    card_type VARCHAR(20) NOT NULL CHECK (card_type IN ('VISA', 'MASTERCARD', 'DISCOVER', 'AMEX')),
    card_last4 VARCHAR(4) NOT NULL,
    cardholder_name VARCHAR(100) NOT NULL,
    amount DECIMAL(15, 2) NOT NULL CHECK (amount > 0),
    transaction_fee DECIMAL(15, 2) NOT NULL DEFAULT 0,
    gateway_ref VARCHAR(100) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT GETDATE(),
    status VARCHAR(20) NOT NULL CHECK (status IN ('SUCCESS', 'FAILED')),
    CONSTRAINT FK_Payment_Order FOREIGN KEY (order_id) REFERENCES ORDERS(order_id)
);
GO