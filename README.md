# 🏀 Blazor Hoops Player Stats Dashboard

A modern, interactive **Blazor Server** application for comprehensive basketball player performance analytics. Built with clean architecture principles and responsive design, this dashboard provides real-time insights into player statistics, fitness metrics, and injury management.

[![.NET](https://img.shields.io/badge/.NET-6.0%7C7.0%7C8.0-512BD4?logo=.net)](https://dotnet.microsoft.com)
[![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?logo=blazor)](https://blazor.net)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-5.x-7952B3?logo=bootstrap)](https://getbootstrap.com)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

## 🌟 Key Features

### 📋 Player Management
- **Comprehensive Player Profiles**: Complete player information with photo, position, and contact details
- **Dynamic Filtering**: Filter players by position (Point Guard, Shooting Guard, Small Forward, Power Forward, Center)
- **Search Functionality**: Quick player lookup with real-time search
- **Responsive Grid Layout**: Optimized for desktop, tablet, and mobile viewing

### 📊 Performance Analytics
- **Match Performance Tracking**: Points, assists, rebounds, and shooting percentages
- **Fitness Monitoring**: Minutes played, sprint counts, endurance metrics
- **Injury Management**: Comprehensive injury history with recovery tracking
- **Visual Data Representation**: Interactive charts, gauges, and progress indicators

### 🎨 User Experience
- **Modern UI Design**: Clean, professional interface with basketball-themed styling
- **Real-time Updates**: Server-side rendering with instant data updates
- **Accessibility**: WCAG compliant with keyboard navigation and screen reader support
- **Mobile-First Design**: Responsive layout that works seamlessly across all devices

## 🏗️ Architecture & Structure

```
Hoops_metrics_web_page/
├── Components/                 # Reusable Blazor components
│   ├── Fitness.razor          # Fitness metrics visualization
│   ├── Injury.razor           # Injury history and status
│   ├── MatchPerformance.razor # Game performance metrics
│   └── PlayerCard.razor       # Individual player card component
├── Data/                      # Data models and services
│   ├── Models/
│   │   ├── Player.cs          # Player entity model
│   │   ├── Fitness.cs         # Fitness data model
│   │   ├── Injury.cs          # Injury tracking model
│   │   └── MatchPerformance.cs # Game statistics model
│   └── Services/
│       ├── PlayerService.cs   # Player data service
│       └── IPlayerService.cs  # Service interface
├── Pages/                     # Blazor pages
│   ├── Index.razor           # Dashboard homepage
│   ├── PlayerDetails.razor   # Individual player view
│   └── PlayerList.razor      # Players listing page
├── wwwroot/                  # Static assets
│   ├── css/
│   │   └── hoopsapp.css     # Custom styling
│   ├── images/              # Player photos and assets
│   └── js/                  # Custom JavaScript
├── Program.cs               # Application entry point
└── appsettings.json        # Configuration settings
```

## 🚀 Quick Start

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) with C# extension
- Git for version control

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/Saadoxyz/Hoops_metrics_web_page.git
   cd Hoops_metrics_web_page
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   Navigate to `https://localhost:5001` or `http://localhost:5000`

### Development Setup

For development with hot reload:
```bash
dotnet watch run
```

## 💻 Technology Stack

| Component | Technology | Purpose |
|-----------|------------|---------|
| **Frontend** | Blazor Server | Interactive web UI with C# |
| **Styling** | Bootstrap 5 + Custom CSS | Responsive design system |
| **Backend** | ASP.NET Core | Web framework and API |
| **Data** | In-Memory (Mock) | Development data store |
| **Icons** | Font Awesome | UI iconography |
| **Charts** | Custom CSS + Blazor | Data visualization |

## 📈 Features in Detail

### Player Dashboard
- **Overview Cards**: Quick stats summary for each player
- **Performance Trends**: Visual representation of player improvement
- **Position Analytics**: Team composition and position distribution
- **Injury Alerts**: Real-time injury status monitoring

### Data Visualization Components
- **Fitness Gauges**: Vertical progress bars showing fitness levels
- **Performance Circles**: Circular progress indicators for key metrics
- **Injury Timeline**: Historical view of injuries and recovery periods
- **Statistics Charts**: Comparative analysis across players

### Responsive Design
- **Mobile Optimization**: Touch-friendly interface for tablets and phones
- **Progressive Enhancement**: Works without JavaScript as fallback
- **Print Styles**: Optimized layouts for printing reports
- **Dark Mode Ready**: Prepared for dark theme implementation

## 🛠️ Development Guidelines

### Code Standards
- **C# Conventions**: Follows Microsoft C# coding conventions
- **Component Design**: Single responsibility principle for Blazor components
- **Naming**: Descriptive names for methods, properties, and variables
- **Documentation**: XML documentation for public methods and classes

### File Organization
- **Components**: Reusable UI elements in `/Components`
- **Pages**: Routable pages in `/Pages`
- **Services**: Business logic in `/Data/Services`
- **Models**: Data structures in `/Data/Models`

## 🚧 Roadmap & Future Enhancements

### Phase 1: Foundation ✅
- [x] Basic player listing and details
- [x] Performance metrics display
- [x] Responsive design implementation
- [x] Custom CSS styling

### Phase 2: Advanced Features 🔄
- [ ] Database integration (Entity Framework Core)
- [ ] Real-time data updates (SignalR)
- [ ] Advanced charts and analytics
- [ ] Player comparison tools

### Phase 3: Enterprise Features 📋
- [ ] User authentication and authorization
- [ ] Role-based access control (Coach, Manager, Player)
- [ ] Data export capabilities (PDF, Excel)
- [ ] Integration with external APIs
- [ ] Advanced reporting dashboard

### Phase 4: Mobile & Cloud ☁️
- [ ] Progressive Web App (PWA) support
- [ ] Offline functionality
- [ ] Cloud deployment (Azure)
- [ ] Mobile app development (MAUI)

## 📚 Learning Resources

This project demonstrates several key Blazor and .NET concepts:

- **Component Architecture**: Building reusable, maintainable UI components
- **Data Binding**: Two-way binding and parameter passing
- **Service Injection**: Dependency injection and service lifecycle
- **Routing**: Navigation and URL parameter handling
- **State Management**: Component state and cascading parameters
- **CSS Integration**: Styling Blazor components effectively

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Contribution Guidelines
- Write clear, descriptive commit messages
- Include tests for new features
- Update documentation as needed
- Follow existing code style and conventions

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **Blazor Team** for the amazing framework
- **Bootstrap Team** for the responsive design system
- **Basketball Community** for inspiration and requirements
- **Open Source Contributors** who make projects like this possible

## 📞 Support & Contact

- **Issues**: [GitHub Issues](https://github.com/Saadoxyz/Hoops_metrics_web_page/issues)
- **Discussions**: [GitHub Discussions](https://github.com/Saadoxyz/Hoops_metrics_web_page/discussions)
- **Documentation**: [Wiki](https://github.com/Saadoxyz/Hoops_metrics_web_page/wiki)
- **Developer**: [Saado](https://github.com/Saadoxyz) - saado652004@gmail.com

---

<div align="center">

**Built with ❤️ for the Basketball Community**

[🌟 Star this repo](https://github.com/Saadoxyz/Hoops_metrics_web_page) • [🐛 Report Bug](https://github.com/Saadoxyz/Hoops_metrics_web_page/issues) • [✨ Request Feature](https://github.com/Saadoxyz/Hoops_metrics_web_page/issues)

</div>
