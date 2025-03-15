# API Documentation

## Users

### Create User
**POST /users**
```json
{
  "first_name": "John",
  "last_name": "Doe",
  "email": "john@example.com",
  "phone": "+123456789"
}
```
**Response:**
```json
{
  "user_id": 1,
  "created_at": "2024-08-22T12:00:00Z",
  "last_update_at": "2024-08-22T12:00:00Z",
  "is_archived": false
}
```

### Get User
**GET /users/{user_id}**

### Update User
**PUT /users/{user_id}**
```json
{
  "first_name": "Jane",
  "email": "jane@example.com"
}
```

### Delete User (Archive)
**DELETE /users/{user_id}**

---

## Products

### Create Product
**POST /products**
```json
{
  "product_name": "Premium Software",
  "product_type": "Subscription"
}
```

### Get Product
**GET /products/{product_id}**

### Update Product
**PUT /products/{product_id}**
```json
{
  "product_name": "Updated Software"
}
```

### Delete Product (Archive)
**DELETE /products/{product_id}**

---

## Subscription Tiers

### Create Subscription Tier
**POST /subscription-tiers**
```json
{
  "product_id": 1,
  "tier_name": "Gold",
  "duration": 30,
  "grace_period": 5,
  "price": 100.0
}
```

### Get Subscription Tier
**GET /subscription-tiers/{tier_id}**

### Update Subscription Tier
**PUT /subscription-tiers/{tier_id}**
```json
{
  "tier_name": "Platinum"
}
```

### Delete Subscription Tier (Archive)
**DELETE /subscription-tiers/{tier_id}**

---

## Subscription Orders

### Create Subscription Order
**POST /subscription-orders**
```json
{
  "subscription_tier_id": 1,
  "user_id": 1,
  "purchase_date": "2024-08-22T12:00:00Z",
  "start_date": "2024-08-23T00:00:00Z",
  "end_date": "2024-09-23T00:00:00Z",
  "status": "active"
}
```

### Get Subscription Order
**GET /subscription-orders/{subscription_id}**

### Update Subscription Order
**PUT /subscription-orders/{subscription_id}**
```json
{
  "status": "expired"
}
```

### Delete Subscription Order (Archive)
**DELETE /subscription-orders/{subscription_id}**

---

## Licenses

### Create License
**POST /licenses**
```json
{
  "product_id": 1,
  "max_devices": 5,
  "duration": 365,
  "grace_period": 30,
  "public_key": "abcd1234",
  "price": 200.0
}
```

### Get License
**GET /licenses/{license_id}**

### Update License
**PUT /licenses/{license_id}**
```json
{
  "price": 250.0
}
```

### Delete License (Archive)
**DELETE /licenses/{license_id}**

---

## License Orders

### Create License Order
**POST /license-orders**
```json
{
  "user_id": 1,
  "license_id": 1,
  "private_key": "encrypted_key",
  "purchase_date": "2024-08-22T12:00:00Z",
  "status": "active"
}
```

### Get License Order
**GET /license-orders/{license_order_id}**

### Update License Order
**PUT /license-orders/{license_order_id}**
```json
{
  "status": "expired"
}
```

### Delete License Order (Archive)
**DELETE /license-orders/{license_order_id}**

---

## License Activations

### Create License Activation
**POST /license-activations**
```json
{
  "license_order_id": 1,
  "device_fingerprint": "device_123",
  "activation_date": "2024-08-22T12:00:00Z"
}
```

### Get License Activation
**GET /license-activations/{activation_id}**

### Delete License Activation (Archive)
**DELETE /license-activations/{activation_id}**

---

## Blacklisted IPs

### Blacklist IP
**POST /blacklisted**
```json
{
  "ip": "192.168.1.1",
  "type": "fraud",
  "blocked_date": "2024-08-22T12:00:00Z",
  "recovery_date": "2024-09-22T12:00:00Z"
}
```

### Get Blacklisted IP
**GET /blacklisted/{blocked_id}**

### Remove Blacklist
**DELETE /blacklisted/{blocked_id}**

