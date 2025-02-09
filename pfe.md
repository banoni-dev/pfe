# schema

user(id, name, email, password,card_id,card_password,card_balance)
product(id, name, price, type)
tier(id, name, price, max_devices, duration, #prod_id)
transaction(id, #user_id, #tier_id, amount, date)
subscription(id, #user_id, #tier_id, start_date,next_due_date,status, device_count, key)
session(id, #user_id, #subscription_id, device_print)


