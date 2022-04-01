import socket
import psycopg2

HOST = '127.0.0.1'
PORT = 65432

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    db_connect = psycopg2.connect(
        dbname = "fpulzzok",
        user = "fpulzzok",
        password = "dA2KPb14SwN0GHa1NIeFbqjviqG6M7sB",
        host = "rogue.db.elephantsql.com"
    )

    cursor = db_connect.cursor()

    s.bind((HOST, PORT))

    s.listen()
    conn, addr = s.accept()

with conn:
    while True:
        data = conn.recv(1024)
        dat = data.decode()
        if dat.find("getAll")>-1:
            cursor.execute("SELECT * from guitars")
            record = str(cursor.fetchall())
            conn.send(str.encode(record))

        if dat.find("Ins")>-1:
            cursor.execute('INSERT INTO guitars (name, type) VALUES ({0})'.format(dat[4:]))
            conn.send(str.encode("inserted"))

        # if not data:
        #     break


cursor.close()
db_connect.close()