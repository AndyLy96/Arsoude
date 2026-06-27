
import 'package:flutter/material.dart';
import 'package:hidden_drawer_menu/hidden_drawer_menu.dart';

class hiddenFilter extends StatefulWidget {
  const hiddenFilter({super.key});

  @override
  State<hiddenFilter> createState() => _hiddenFilterState();
}

class _hiddenFilterState extends State<hiddenFilter> {

  List<ScreenHiddenDrawer> _pages = [];

  @override
  void initState() {
    _pages.add(ScreenHiddenDrawer(
        ItemHiddenMenu(
          name: "Exit",
          baseStyle: TextStyle(color: Colors.white.withOpacity(0.8), fontSize: 28.0),
          colorLineSelected: Colors.white, selectedStyle: TextStyle(color: Colors.white.withOpacity(0.8), fontSize: 28.0),
        ),
        Container(
            child: Column(
              children: [
                Text("Filter", style: TextStyle(color: Colors.white.withOpacity(0.8), fontSize: 28.0),),

              ],
            )
        )
    ));
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return HiddenDrawerMenu(
        screens: _pages,
        backgroundColorMenu: Color(0xFF66C477),

    );
  }
}


