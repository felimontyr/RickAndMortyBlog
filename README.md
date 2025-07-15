"# RickAndMortyBlog" 
# Visor de Personajes de Rick and Morty 🧪🚀

Este proyecto es una aplicación web desarrollada en **Blazor WebAssembly** que consume la API pública de Rick and Morty y permite al usuario visualizar, filtrar y votar personajes con likes y dislikes.


## 🧩 Funcionalidades principales

- ✅ Mostrar personajes en tarjetas con imagen, nombre, estado, especie y género.
- ✅ Votar por personaje con botones de Like o Dislike.
- ✅ Mostrar el puntaje individual por personaje.
- ✅ Mostrar total global de Likes y Dislikes.
- ✅ Filtros dinámicos por nombre, especie y estado.
- ✅ Animaciones suaves en tarjetas y puntaje.
- ✅ Diseño visual personalizado y responsive.

---

## 🔧 Instrucciones para ejecutar la app

### Requisitos:
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download) o superior

### Pasos:

- en consola: 
- git clone https://github.com/felimontyr/RickAndMortyBlog.git
- cd rickAndMortyVisor
- dotnet run

## 📌 Cómo se consumió la API

- La aplicación consume datos desde la API pública:

- https://rickandmortyapi.com/api/character

- Se creó un servicio personalizado llamado `RickAndMortyService.cs` que utiliza `HttpClient` para hacer    una solicitud GET y mapear la respuesta a una lista de objetos `Character`.

```bash
 public async Task<List<Character>> GetCharactersAsync()
 {
    var response = await _http.GetFromJsonAsync<ApiResponse>("https://rickandmortyapi.com/api/character");
    return response?.Results ?? new List<Character>();
 }
```

## 📌 Estructura del codigo

```
 RickAndMortyVisor/
│
├── Pages/
│   └── Index.razor                
├── Shared/
│   └── CharacterCard.razor       
├── Services/
│   └── RickAndMortyService.cs    
├── Models/
│   └── Character.cs             
├── Program.cs                   
├── App.razor / MainLayout.razor 
├── README.md
```
## ✨ Funcionalidades adicionales implementadas

- Filtro por nombre, especie y estado.

- Totales de likes y dislikes globales, actualizados al votar.

- Estilo visual personalizado y diseño responsive.

- Animaciones suaves al hacer like/dislike.

- Accesibilidad básica en botones (íconos y colores distintivos).

## 💡 Decisiones técnicas
- Se eligió Blazor WebAssembly para aprovechar experiencia previa y por ser una opción válida propuesta.

- Se utilizó HttpClient de forma nativa sin librerías externas.

## 💡 Propuesta de mejora

- La persistencia de votos de muy importante para un uso real y a escala, el cual con mas tiempo es posible hacer.

- Que cada personaje tenga un apartado mas individual con mas informacion.

- Agregar animaciones visuales mas vistosas y llamativas para el usuario.
