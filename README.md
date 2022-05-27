# BibliotekaRSO
Należy zrealizować usługę pozwalająca na:  - wyszukiwanie książki na podstawie słowa w tytule. 
Metoda usługi przyjmuje jako argument łańcuch tekstowy i zwraca listé identyfikatorów książkiek typu integer  - pobieranie szczegółów książki. 
Metoda przyjmuje jako argument identyfikator książki typu integer i zwraca strukturę zawierającą tytuł i listę autorów (lista struktur: imię, nazwisko).
W przypadku niepoprawnego identyfikatora usługa zgłasza błąd (należy zdefiniować klasę dla kontrkatu błędów)  Usługa może mieć predefiniowaną listę kilku książek.
Klient w fromie aplikacji konsolowej powinien wykonywać przykładowe operacje, wyświetlać szczegóły odnalezionych książek i poprawnie obsługiwać błędy.
