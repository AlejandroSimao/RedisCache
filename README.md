# Redis Integration in ASP.NET API

### Introduction

This API integrates Redis as a caching solution to improve performance by reducing the number of database queries and speeding up data retrieval. The API is built using ASP.NET Core and follows a layered architecture.

Redis is an in-memory key-value store that can be used for various purposes such as caching, session management, and real-time data streaming.

### Features

+ Data Caching: Reduce the load on the database by storing frequently accessed data in Redis.
+ Session Management: Persist user session data efficiently.
+ High Performance: Handle high volumes of data with low-latency responses.
+ Scalability: Redis offers distributed and scalable caching capabilities.

### Prerequisites

+ .NET SDK (= 8.0)
+ Redis server (can be local or hosted, e.g., Redis Cloud, Docker, etc.)

### Installing Redis on Docker (optional)
To run Redis in a Docker container, execute:
```
docker run -d -p 6379:6379 redis
```
