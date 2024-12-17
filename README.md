# Employee Management System

Bu proje, çalışan yönetimini kolaylaştırmak için geliştirilmiş bir **C# Windows Forms Application**'dır. Sistem, admin paneli üzerinden çalışan ekleme, maaş düzenleme ve genel yönetim işlemlerini yapabilmenizi sağlar. Veritabanı olarak **Microsoft SQL Server** kullanılmaktadır.

## Özellikler

1. **Admin Login ve Admin Sign Up**:
   - Admin kullanıcıları sisteme giriş yapabilir ve yeni admin hesapları oluşturabilir.

2. **Dashboard**:
   - Sisteme giriş yaptıktan sonra, kullanıcıyı karşılayan ana ekran.
   
3. **Salary Designer**:
   - Çalışan maaşlarını düzenlemek için kullanılabilir bir arayüz.
   
4. **Add Employee**:
   - Yeni çalışan eklemek için form sunar.
   
5. **Dashboard**:
   - Genel verileri ve yönetim araçlarını sunan ana yönetim paneli.

## Kullanılan Teknolojiler

- **Backend**: C# (Windows Forms Application)
- **Veritabanı**: Microsoft SQL Server
- **Authentication**: Admin login ve sign-up işlemleri için güvenli kimlik doğrulama.
- **UI**: Windows Forms için standart UI kontrolleri (Button, TextBox, DataGridView vb.)

## Kurulum

1. Bu projeyi GitHub'dan klonlayın:

    ```HTTPS
    https://github.com/saraalmemar/Employee-Management-System.git
    ```

2. **employee.mdf** dosyasını projenize dahil edin.
   - **employee.mdf** dosyasını projeye eklemek için `Solution Explorer`'da projeye sağ tıklayın ve **Add > Existing Item** seçeneği ile **employee.mdf** dosyasını ekleyin.

3. **Microsoft SQL Server**'ı kurun ve gerekli tabloları oluşturun. Projeye ait veritabanı bağlantı dizesini ayarlamak için **Login.cs** dosyasını şu şekilde güncelleyin

4. Visual Studio'yu açın ve projeyi açın.

5. **NuGet Paketlerini Yükleyin**: Proje, SQL Server bağlantısı için `System.Data.SqlClient` gibi gerekli NuGet paketlerine ihtiyaç duyabilir.

6. Projeyi **Build** edin ve çalıştırın.

## Kullanım

- **Admin Login** ekranına giriş yaparak admin paneline ulaşabilirsiniz.
- Admin panelinde:
  - Yeni çalışan ekleyebilir.
  - Çalışanların maaş bilgilerini düzenleyebilirsiniz.
  - Genel verileri yönetebilirsiniz.
  
## Katkıda Bulunma

Eğer projeye katkı sağlamak isterseniz, lütfen aşağıdaki adımları takip edin:

1. Bu projeyi **fork**'layın.
2. Kendi dalınızı (**branch**) oluşturun.
3. Yapmak istediğiniz değişiklikleri ekleyin.
4. Değişikliklerinizi **commit** edin ve **pull request** oluşturun.
