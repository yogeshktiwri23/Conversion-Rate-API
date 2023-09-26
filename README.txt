# Conversion Rate API

A RESTful API for unit conversion rates.

## Table of Contents

- [Project Description](#project-description)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
- [Usage](#usage)
- [Configuration](#configuration)



## Project Description

The Conversion Rate API is a web service that allows users to convert units between metric and imperial systems. 
It provides conversion rates for various unit types, including length, weight, and temperature.

## Getting Started

To get started with the Conversion Rate API, follow the instructions below.

### Prerequisites

Before you begin, ensure you have the following software and tools installed:

- [.NET Core SDK]
- [Visual Studio 2022]

## Usage
You can use the Conversion Rate API to perform unit conversions. Here are some sample requests:

Convert 5 meters to feet:
GET http://localhost:5000/api/conversion/convert?value=5&fromUnit=meters&toUnit=feet&conversionType=Length
Convert 10 kilograms to pounds:
GET http://localhost:5000/api/conversion/convert?value=10&fromUnit=kilograms&toUnit=pounds&conversionType=Weight
Convert 20 degrees Celsius to Fahrenheit:
GET http://localhost:5000/api/conversion/convert?value=20&fromUnit=celsius&toUnit=fahrenheit&conversionType=Temperature

##Configuration
The Conversion Rate API uses a SQL database to store conversion rates. You can configure the database connection string in the appsettings.json file.
use below query to create db table and insert dummy records

CREATE TABLE ConversionRate (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ConversionType NVARCHAR(255) NOT NULL,
    FromUnit NVARCHAR(255) NOT NULL,
    ToUnit NVARCHAR(255) NOT NULL,
    Rate FLOAT NOT NULL
);

INSERT INTO ConversionRate (ConversionType, FromUnit, ToUnit, Rate)
VALUES
    ('Length', 'meters', 'feet', 3.28084),
    ('Length', 'feet', 'meters', 0.3048),
    ('Weight', 'kilograms', 'pounds', 2.20462),
    ('Weight', 'pounds', 'kilograms', 0.453592),
    ('Temperature', 'celsius', 'fahrenheit', 1.8),
    ('Temperature', 'fahrenheit', 'celsius', -1.11111);

