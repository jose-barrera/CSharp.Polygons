# Polygons Visualizer

This is a simple program that paints polygons on a canvas and let the user performs basic tasks. It ejemplifies **inheritance**, **virtual methods** and **overriding**, **protected** and **private** access. It implements the following classes:

* **Point** - A cartesian point.
* **Polygon** - A collection of consecutive and connected points that represents a closed polygon.
* **PolygonR** - A regular polygon, inherits from *Polygon*.
* **Rectangle** - A rectangle, inherits from *Polygon*.
* **Square** - A square, inherits from *PolygonR*.
* **PentagonR** - A regular pentagon, inherits from *PolygonR*.
* **HexagonR** - A regular hexagon, inherits from *PolygonR*.
* **HeptagonR** - A regular heptagon, inherits from *PolygonR*.
* **OctagonR** - A regular octagon, inherits from *PolygonR*.
* **DecagonR** - A regular decagon, inherits from *PolygonR*.
* **Dodecagon** - A regular dodecagon, inherits from *PolygonR*.

The user can paint any free-form polygon from a collection of vertices, or using a line segment to build a specific type of polygon. All controls are set according the state of the program. When double click on a polygon from the list, it shows an info dialog with polygon properties.
