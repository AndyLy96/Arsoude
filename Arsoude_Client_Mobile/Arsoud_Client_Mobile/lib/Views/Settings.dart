import 'package:flutter/material.dart';
import 'package:untitled/Http/HttpService.dart';
import 'package:untitled/Http/Models.dart';
import '../generated/l10n.dart';

enum HikeType { walking, bicycle, both }

class SettingsPage extends StatefulWidget {
  const SettingsPage({Key? key}) : super(key: key);

  @override
  State<SettingsPage> createState() => _SettingsPageState();
}

class _SettingsPageState extends State<SettingsPage> {
  bool enableNotifications = false;
  double distance = 10.0;
  HikeType selectedHikeType = HikeType.walking;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(S.of(context).Settings),
      ),
      body: SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const SizedBox(height: 40),
            _buildSectionTitle(S.of(context).notifSettings),
            _buildNotificationSettings(),
            const SizedBox(height: 40),
            _buildSectionTitle(S.of(context).notifSettingsTypes),
            _buildHikeTypes(),
            const SizedBox(height: 40),
            _buildSectionTitle(S.of(context).notifSettingsDistance),
            _buildDistanceSlider(),
            const SizedBox(height: 40),
          ],
        ),
      ),
      floatingActionButton: confirmationButton(context),
    );
  }

  FloatingActionButton confirmationButton(BuildContext context) {
    return FloatingActionButton(
      onPressed: () {
        // Add your confirmation logic here
        showDialog(
          context: context,
          builder: (BuildContext context) {
            return AlertDialog(
              title: const Text("Confirmation"),
              content: Text(S.of(context).confirmSettings),
              actions: <Widget>[
                TextButton(
                  onPressed: () {
                    _saveSettings();
                    Navigator.of(context).pop();
                  },
                  child: Text(S.of(context).Yes),
                ),
                TextButton(
                  onPressed: () {
                    Navigator.of(context).pop();
                  },
                  child: Text(S.of(context).No),
                ),
              ],
            );
          },
        );
      },
      child: const Icon(Icons.check),
    );
  }

  Widget _buildSectionTitle(String title) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16.0),
      child: Text(
        title,
        style: const TextStyle(
          fontSize: 18,
          fontWeight: FontWeight.bold,
        ),
      ),
    );
  }

  Widget _buildNotificationSettings() {
    return ListTile(
      title: Text(S.of(context).ActivateNotifs),
      trailing: Switch(
        activeColor: Colors.green,
        value: enableNotifications,
        onChanged: (value) {
          setState(() {
            enableNotifications = value;
            if (!enableNotifications) {
              // Reset settings
              _resetSettings();
            }
          });
        },
      ),
    );
  }

  Widget _buildHikeTypes() {
    return Column(
      children: [
        RadioListTile<HikeType>(
          title: Text(S.of(context).Walking),
          value: HikeType.walking,
          groupValue: selectedHikeType,
          onChanged: (HikeType? value) {
            setState(() {
              selectedHikeType = value!;
              enableNotifications = true; // Automatically turn on notifications
            });
          },
        ),
        RadioListTile<HikeType>(
          title:  Text(S.of(context).Bycicle),
          value: HikeType.bicycle,
          groupValue: selectedHikeType,
          onChanged: (HikeType? value) {
            setState(() {
              selectedHikeType = value!;
              enableNotifications = true; // Automatically turn on notifications
            });
          },
        ),
        RadioListTile<HikeType>(
          title: Text(S.of(context).Both),
          value: HikeType.both,
          groupValue: selectedHikeType,
          onChanged: (HikeType? value) {
            setState(() {
              selectedHikeType = value!;
              enableNotifications = true; // Automatically turn on notifications
            });
          },
        ),
      ],
    );
  }

  Widget _buildDistanceSlider() {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 16.0),
      child: Slider(
        value: distance,
        min: 0.0,
        max: 100.0,
        divisions: 100,
        label: '${distance.round()} km',
        onChanged: (value) {
          setState(() {
            distance = value;
            enableNotifications = true; // Automatically turn on notifications
          });
        },
      ),
    );
  }

  void _resetSettings() {
    setState(() {
      selectedHikeType = HikeType.walking;
      distance = 10.0;
    });
  }

  Future<void> _saveSettings() async {
    NotificationSettings nots = NotificationSettings();
    nots.distance = distance;
    nots.type = _getHikeTypeValue(selectedHikeType);
    nots.isTurnedOn = true;

    changeNotificationSettings(nots);
  }

  int _getHikeTypeValue(HikeType hikeType) {
    switch (hikeType) {
      case HikeType.walking:
        return 0;
      case HikeType.bicycle:
        return 1;
      case HikeType.both:
        return 2;
    }
  }
}
