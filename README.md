# Gacha

Notion データベースと連携したガチャシミュレーションシステム

## 概要

Unityベースのガチャシステムアプリケーションです。Notion APIからキャラクター/アイテムデータを取得し、レアリティに基づいた確率抽選を行います。

## 機能

- **通常ガチャ**: レアリティごとの確率に基づくランダム抽選
- **ピックアップガチャ**: 最低レアリティ保証付きの特別抽選
- **在庫管理**: 抽選済みアイテムのストック機能
- **Notion連携**: 外部データベースからのリアルタイムデータ取得
- **レアリティシステム**: 3段階のレアリティ（0: 低 / 1: 中 / 2: 高）

## 必要条件

- Unity 6000.0.59f2 以降
- Notion API アクセストークン
- Notion データベース

## セットアップ

1. リポジトリをクローン
   ```bash
   git clone <repository-url>
   ```

2. Unity Hubでプロジェクトを開く

3. Notion設定を構成
   - `Assets/Scripts/SO/NotionSetting.cs` に基づいてScriptableObjectを作成
   - Notion APIトークンを設定
   - データベースIDを設定
   - APIエンドポイントURIを設定

4. `Assets/Scenes/Gacha.unity` シーンを開いて実行

## 使用方法

| ボタン | 機能 |
|--------|------|
| DoGacha | 通常ガチャを引く |
| DoPickup | ピックアップガチャを引く |
| DoStock | 現在のキャラクターを在庫に戻す |

## プロジェクト構成

```
Assets/
├── Scripts/
│   ├── Manager.cs           # メインゲームコントローラー
│   ├── Network/
│   │   ├── HTTPRequest.cs   # HTTP通信処理
│   │   └── WebRequest.cs    # リクエストラッパー
│   └── SO/
│       └── NotionSetting.cs # Notion設定用ScriptableObject
├── Scenes/
│   └── Gacha.unity          # メインシーン
├── Button.prefab            # UIボタンプレハブ
└── Settings/                # URP設定
```

## 技術スタック

- **エンジン**: Unity 6 (6000.0.59f2)
- **言語**: C#
- **レンダリング**: Universal Render Pipeline (URP) 17.0.4
- **外部連携**: Notion API

## ガチャ確率

### 通常ガチャ
各キャラクターのレートに基づく重み付けランダム抽選

### ピックアップガチャ
| 確率 | 最低レアリティ |
|------|----------------|
| 60%  | レアリティ2    |
| 80%  | レアリティ1    |
| 99%  | レアリティ0    |

## ライセンス

このプロジェクトのライセンスについては、プロジェクトオーナーにお問い合わせください。
