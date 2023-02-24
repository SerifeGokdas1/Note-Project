# Not Projesi
### Web Uygulaması 
#### ASP.Net MVC, Dapper ve Store Prosedür ile yazılmıştır. Admin paneli ve kullanıcı paneli olmak üzere iki farklı arayüze sahiptir. Kullanıcılar admin panelinden oluşturulan hakkımızda, blog, plan vb. sayfalara ulaşabilmesinin yanında kendi notlarını ve yapılacaklar listelerini oluşturabiliyorlar. Site içerisindeki tüm bilgilerin yönetildiği admin panelinde ise yöneticiler, hakkımızda, blog, plan vb. sayfaların CRUD işlemlerini gerçekleştirmesinin yanında kullanıcıların oluşturdukları içerikleri görüntüleyebilmekte ve CRUD işlemlerini oluşturabilmektedir. 

> Projenin çıktısını görmek ve detaylı incelemek isterseniz [bu Youtube bağlantısından](https://www.youtube.com/watch?v=Pox5cUKSTf8&ab_channel=Serife
) videoya ulaşabilirsiniz.

### Projede Oluşturulan Tablolar, Diyagram ve Store Prosedürler
- Diyagram ve Tablolar
###### Tablolar arasında bir ilişki bulunmadığı için bağlantı oluşturulmamıştır.

![Diagram ve Tablolar](https://user-images.githubusercontent.com/117410162/220938977-5545a75d-681c-4c53-85d9-363c2504d4ce.jpg)

- Store Prosedürler
###### Silme ve listeleme için oluşturduğum saklı yordamlar

![Note-Project-StoreProsedure1](https://user-images.githubusercontent.com/117410162/220939321-5a26c220-3e58-4821-b1a5-7a81280c7196.jpg)

###### Ekleme ve güncellemeyi bir arada oluşturduğum saklı yordam

![Note-Project-StoreProsedure2](https://user-images.githubusercontent.com/117410162/220939404-a20c3c9f-6622-4016-b769-043a5f442166.jpg)

### Projenin Kod Kısımları

#### Models klasörünün içinde her tablo için class oluşturdum ve içerisine tablonun propertylerini yazdım.

![Models](https://user-images.githubusercontent.com/117410162/220947377-cf6af951-ee5b-4650-b0e8-bb39435de615.jpg)

#### Models klasörünün içinde DP adında bir class oluşturdum ve burada SQL ile bağlantılarımı gerçekleştirdim.

![Models-DP](https://user-images.githubusercontent.com/117410162/220947775-3ebb5a36-80d4-47e6-a405-b32d0b5fa227.jpg)

#### Controller klasörünün içine her tablo için controller oluşturdum.

![Controllers](https://user-images.githubusercontent.com/117410162/220947991-32ec0189-ffd8-467f-b374-9e24dae6b803.jpg)

#### Kullanıcılardan alınan istekleri controllera ileten ve projenin arayüzünü oluşturan View klasöründe, controllerda oluşturulan Index ve AddUpdatein arayüz kodlarını yazdım.

###### View klasöründeki Index 

![View- Index](https://user-images.githubusercontent.com/117410162/220950280-62245da3-5be4-4e4d-8049-1d934ae83072.jpg)

###### View klasöründeki AddUpdate 

![View- AddUpdate](https://user-images.githubusercontent.com/117410162/220950369-b523d58c-30ef-4b06-ae81-c0948879e3cd.jpg)

>Projenin içinde kullanılan eklentiler ve daha detaylı anlatım için [bu Medium bağlantısından](https://medium.com/@serifegokdaas/asp-net-mvc-dapper-web-uygulamas%C4%B1-d67ce0ddb5a8) yazıya ulaşabilirsiniz.

>*Proje hakkında soru sormak veya geri bildirimde bulunmak isterseniz serifegokdaas@gmail.com adresinden benimle iletişime geçebilirsiniz.*




