# Schema

user(id, name, email, password, card_id, card_password, card_balance)  
product(id, name, price, type)  
tier(id, name, price, max_devices, duration, #prod_id)  
transaction(id, #user_id, #tier_id, amount, date)  
subscription(id, #user_id, #tier_id, start_date, next_due_date, status, device_count, key)  
session(id, #user_id, #subscription_id, device_print)  

# API Endpoints

### User


- **POST /users**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "name": "John Doe", 
    "email": "john@example.com", 
    "password": "hashed_password", 
    "card_id": "123456", 
    "card_password": "securepass", 
    "card_balance": 100.0
  }
  ```  
  Function: `createUser`

- **GET /users/{id}**  
  Function: `getUserById`

- **PUT /users/{id}**  
  Request body:  
  ```json
  {
    "name": "Updated Name",
    "email": "new@example.com"
  }
  ```  
  Function: `updateUser`

- **DELETE /users/{id}**  
  Function: `deleteUser`

---

### Product

- **POST /products**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "name": "Premium Subscription", 
    "price": 50.0, 
    "type": "subscription"
  }
  ```  
  Function: `createProduct`

- **GET /products/{id}**  
  Function: `getProductById`

- **PUT /products/{id}**  
  Request body:  
  ```json
  { 
    "name": "Updated Product", 
    "price": 60.0 
  }
  ```  
  Function: `updateProduct`

- **DELETE /products/{id}**  
  Function: `deleteProduct`

---

### Tier

- **POST /tiers**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "name": "Gold", 
    "price": 100.0, 
    "max_devices": 5, 
    "duration": 30, 
    "prod_id": 1 
  }
  ```  
  Function: `createTier`

- **GET /tiers/{id}**  
  Function: `getTierById`

- **PUT /tiers/{id}**  
  Request body:  
  ```json
  { 
    "name": "Platinum", 
    "price": 150.0, 
    "max_devices": 10, 
    "duration": 60 
  }
  ```  
  Function: `updateTier`

- **DELETE /tiers/{id}**  
  Function: `deleteTier`

---

### Transaction

- **POST /transactions**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "user_id": 1, 
    "tier_id": 1, 
    "amount": 100.0, 
    "date": "2024-08-22" 
  }
  ```  
  Function: `createTransaction`

- **GET /transactions/{id}**  
  Function: `getTransactionById`

- **GET /transactions/user/{user_id}**  
  Function: `getUserTransactions`

---

### Subscription

- **POST /subscriptions**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "user_id": 1, 
    "tier_id": 1, 
    "start_date": "2024-08-22", 
    "next_due_date": "2024-09-22", 
    "status": "active", 
    "device_count": 2, 
    "key": "ABC123XYZ" 
  }
  ```  
  Function: `createSubscription`

- **GET /subscriptions/{id}**  
  Function: `getSubscriptionById`

- **GET /subscriptions/user/{user_id}**  
  Function: `getUserSubscriptions`

- **PUT /subscriptions/{id}**  
  Request body:  
  ```json
  { 
    "status": "expired" 
  }
  ```  
  Function: `updateSubscriptionStatus`

- **DELETE /subscriptions/{id}**  
  Function: `cancelSubscription`

---

### Session

- **POST /sessions**  
  Request body:  
  ```json
  { 
    "id": 1, 
    "user_id": 1, 
    "subscription_id": 1, 
    "device_print": "device-fingerprint" 
  }
  ```  
  Function: `createSession`

- **GET /sessions/{id}**  
  Function: `getSessionById`

- **GET /sessions/user/{user_id}**  
  Function: `getUserSessions`

- **DELETE /sessions/{id}**  
  Function: `deleteSession`

