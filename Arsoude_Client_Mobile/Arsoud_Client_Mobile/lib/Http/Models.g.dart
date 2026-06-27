// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Models.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

HelloWorld _$HelloWorldFromJson(Map<String, dynamic> json) =>
    HelloWorld()..text = json['text'] as String;

Map<String, dynamic> _$HelloWorldToJson(HelloWorld instance) =>
    <String, dynamic>{
      'text': instance.text,
    };

LoginDTO _$LoginDTOFromJson(Map<String, dynamic> json) => LoginDTO()
  ..username = json['username'] as String
  ..password = json['password'] as String;

Map<String, dynamic> _$LoginDTOToJson(LoginDTO instance) => <String, dynamic>{
      'username': instance.username,
      'password': instance.password,
    };

Randonne _$RandonneFromJson(Map<String, dynamic> json) => Randonne()
  ..id = json['id'] as int
  ..name = json['name'] as String
  ..description = json['description'] as String
  ..location = json['location'] as String
  ..type = json['type'] as int
  ..imageUrl = json['imageUrl'] as String?
  ..startingCoordinates =
      Coordinates.fromJson(json['startingCoordinates'] as Map<String, dynamic>)
  ..endingCoordinates =
      Coordinates.fromJson(json['endingCoordinates'] as Map<String, dynamic>)
  ..isPublic = json['isPublic'] as bool
  ..rating = (json['rating'] as num?)?.toDouble();

Map<String, dynamic> _$RandonneToJson(Randonne instance) => <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'description': instance.description,
      'location': instance.location,
      'type': instance.type,
      'imageUrl': instance.imageUrl,
      'startingCoordinates': instance.startingCoordinates,
      'endingCoordinates': instance.endingCoordinates,
      'isPublic': instance.isPublic,
      'rating': instance.rating,
    };

Hike _$HikeFromJson(Map<String, dynamic> json) => Hike()
  ..date = DateTime.parse(json['date'] as String)
  ..time = json['time'] as String
  ..Distance = json['Distance'] as int
  ..TrailId = json['TrailId'] as int
  ..isCompleted = json['isCompleted'] as bool;

Map<String, dynamic> _$HikeToJson(Hike instance) => <String, dynamic>{
      'date': instance.date.toIso8601String(),
      'time': instance.time,
      'Distance': instance.Distance,
      'TrailId': instance.TrailId,
      'isCompleted': instance.isCompleted,
    };

Event _$EventFromJson(Map<String, dynamic> json) => Event()
  ..date = DateTime.parse(json['date'] as String)
  ..userName = json['userName'] as String
  ..isCompleted = json['isCompleted'] as bool
  ..isNew = json['isNew'] as bool
  ..trail = Randonne.fromJson(json['trail'] as Map<String, dynamic>);

Map<String, dynamic> _$EventToJson(Event instance) => <String, dynamic>{
      'date': instance.date.toIso8601String(),
      'userName': instance.userName,
      'isCompleted': instance.isCompleted,
      'isNew': instance.isNew,
      'trail': instance.trail,
    };

NotificationSettings _$NotificationSettingsFromJson(
        Map<String, dynamic> json) =>
    NotificationSettings()
      ..type = json['type'] as int
      ..distance = (json['distance'] as num).toDouble()
      ..isTurnedOn = json['isTurnedOn'] as bool;

Map<String, dynamic> _$NotificationSettingsToJson(
        NotificationSettings instance) =>
    <String, dynamic>{
      'type': instance.type,
      'distance': instance.distance,
      'isTurnedOn': instance.isTurnedOn,
    };

Coordinates _$CoordinatesFromJson(Map<String, dynamic> json) => Coordinates()
  ..latitude = (json['latitude'] as num).toDouble()
  ..longitude = (json['longitude'] as num).toDouble();

Map<String, dynamic> _$CoordinatesToJson(Coordinates instance) =>
    <String, dynamic>{
      'latitude': instance.latitude,
      'longitude': instance.longitude,
    };

ImageRequestModel _$ImageRequestModelFromJson(Map<String, dynamic> json) =>
    ImageRequestModel()..url = json['url'] as String;

Map<String, dynamic> _$ImageRequestModelToJson(ImageRequestModel instance) =>
    <String, dynamic>{
      'url': instance.url,
    };

RatingRequestModel _$RatingRequestModelFromJson(Map<String, dynamic> json) =>
    RatingRequestModel()..Rating = json['Rating'] as String;

Map<String, dynamic> _$RatingRequestModelToJson(RatingRequestModel instance) =>
    <String, dynamic>{
      'Rating': instance.Rating,
    };

FilterDTO _$FilterDTOFromJson(Map<String, dynamic> json) => FilterDTO()
  ..keyWord = json['keyWord'] as String?
  ..type = json['type'] as int?
  ..coordinates = json['coordinates'] == null
      ? null
      : Coordinates.fromJson(json['coordinates'] as Map<String, dynamic>)
  ..distance = json['distance'] as int?;

Map<String, dynamic> _$FilterDTOToJson(FilterDTO instance) => <String, dynamic>{
      'keyWord': instance.keyWord,
      'type': instance.type,
      'coordinates': instance.coordinates,
      'distance': instance.distance,
    };
