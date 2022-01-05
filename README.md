

## Sistem Jual Beli Mobil

* Anggota Kelompok : Agung Reza Vergiawan, Yuli, Nadya, Maudy

Class :
Users

Jenis Mobil

Mobil

Pembeli

Buku Penjualan 

Forms :

Sign in 

Sign Up

Jenis Mobil

Tambah Jenis Mobil
Edit Jenis Mobil
Hapus Jenis Mobil


Mobil
Tambah Mobil
Edit Mobil
Hapus Mobil

Pembeli
Tambah Pembeli
Edit Pembeli
Hapus Pembeli

Buku Penjualan
Tambah Buku Penjualan
Edit Buku Penjualan
Hapus Buku Penjualan

Fitur:
Sign In, Sign Out, dan Sign Up
User merupakan admin yang mengurus penjualan mobil
Jenis mobil merupakan jenis mobil yang akan di jual, biasanya berisi sedan, van, suv, pick up, box etc.
Form Mobil Merupakan katalog list mobil yang pernah di jual 
Form Pembeli merupakan informasi pribadi pembeli (nik, nama, alamat)
Buku penjualan tidak dapat diisi sebelum ada informasi pembeli
Buku Penjualan merupakan info mobil apa yang dijual beserta pembeli dan harga terjual berdasarkan kesepakatan sales dengan pembeli

Table :
Users (id_user, user, email, password)
Jenis_mobil (id_jenis, jenis)
Mobil (id, id_jenis_mobil, tipe mobil, tahun_pembuatan, kondisi, harga, garansi, status_terjual, harga_default)
Pembeli (id_pembeli, nik, nama, alamat)
Buku Penjualan (id_penjualan, id_mobil, id_pembeli, harga_terjual,  tanggal_penjualan)
