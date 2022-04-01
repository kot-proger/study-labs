import socket

HOST = '127.0.0.1'
PORT = 65432
with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.connect((HOST, PORT))
    s.sendall(b'getAll')
    data = s.recv(1024)
    print('Command "getAll" .Recieved: ', data.decode())

    s.sendall(b"Ins 'Fender Bass', 'Bass'")
    data1 = s.recv(1024)
    print('Command "Ins" .Recieved: ', data1.decode())

    s.sendall(b'getAll')
    data2 = s.recv(1024)
    print('Command "getAll" Recieved: ', data2.decode())